using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ChartDirector;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using SurfaceChart = ChartDirector.SurfaceChart;

namespace _494KazantsevAM_Variant_7
{
    public partial class RezultCalculateForm : Form
    {
        Model model;
        MainForm mainForm;
        string nameSelectedMethod = "", namefirstparam = "X", namesecondparam = "Y";
        double firstparamextr = 0, secondparamextr = 0, funcparamextr = 0;
        public void SetNameSelctedMethod(string name, string namefirstparam, string namesecondparam, bool flag)
        {
            nameSelectedMethod = name;
            this.namefirstparam = namefirstparam;
            this.namesecondparam = namesecondparam;
            dtablerezultmethod.Columns[0].HeaderText = namefirstparam;
            dtablerezultmethod.Columns[1].HeaderText = namesecondparam;
            if(flag)
                dtablerezultmethod.Columns[2].HeaderText = model.Targertfuntion.Substring(0, 1);
        }
        public void SetExtremumValue(double firstparamextr, double secondparamextr, double funcparamextr)
        {
            this.firstparamextr = firstparamextr;
            this.secondparamextr = secondparamextr;
            this.funcparamextr = funcparamextr;
        }
        public void SetFlagSaveData(bool flagsavedata)
        {
            сохранитьОтчетToolStripMenuItem.Enabled = flagsavedata;
        }
        public RezultCalculateForm(MainForm mainForm ,Model model)
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
            this.model = model;
            this.mainForm = mainForm;
            winChartViewer1.Visible = false;
        }
        public void AddNewRowGraphTable(double[] newrowgraph)
        {
            int temp = dataGridViewGraphValue.Rows.Count-1;
            dataGridViewGraphValue.Rows.Add();
            for (int i = 0; i < 3; i++)
                dataGridViewGraphValue.Rows[temp].Cells[i].Value = newrowgraph[i].ToString();
            
        }
        public void ClearRowGraphTable()
        {
            dataGridViewGraphValue.Rows.Clear();
        }
        public void ClearRezultMethodTable()
        {
            dtablerezultmethod.Rows.Clear();
        }
        public void AddNewRowRezultMethodTable(string[] newrowgraph)
        {
            int temp = dtablerezultmethod.Rows.Count - 1;
            dtablerezultmethod.Rows.Add();
            for (int i = 0; i < 3; i++)
                dtablerezultmethod.Rows[temp].Cells[i].Value = newrowgraph[i];

        }
        public void RenameColumnGraphTable(string newname, int idcolumn)
        {
            dataGridViewGraphValue.Columns[idcolumn].HeaderText = newname;
        }

        private void скрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Visible = true;
            this.Visible = false;
        }

        private void dгToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewGraphValue.RowCount > 2)
            {
                this.Text = "2D-график";
                this.Width = 520;
                this.Height = 530;
                createChart(winChartViewer1, 1);
                winChartViewer1.Visible = true;
                dtablerezultmethod.Visible = false;
            }
            else
                MessageBox.Show("Для построения линий равных значений целевой функции необходимо произвести расчеты!", "Графики не были построены!");
        }

        private void dграфикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewGraphValue.RowCount > 2)
            {
                this.Text = "3D-график";
                this.Width = 620;
                this.Height = 630;
                createChart3D(winChartViewer1, 1);
                winChartViewer1.Visible = true;
                dtablerezultmethod.Visible = false;
            }
            else
                MessageBox.Show("Для построения поверхности отклика целевой функции необходимо произвести расчеты!", "Графики не были построены!");
        }
        public void createChart(WinChartViewer viewer, int chartIndex)
        {
            // координаты Х,Y, значения Z
            //double[] dataX = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double[] dataY = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] dataY = new double[dataGridViewGraphValue.RowCount];
            double[] dataX = new double[dataGridViewGraphValue.RowCount];
            double[] dataZ = new double[dataGridViewGraphValue.RowCount];

            double[] dataYMethod;
            double[] dataXMethod;

            for (int i = 0; i < dataGridViewGraphValue.RowCount - 1; i++)
            {
                dataX[i] = double.Parse(dataGridViewGraphValue.Rows[i].Cells[0].Value.ToString());
                dataY[i] = double.Parse(dataGridViewGraphValue.Rows[i].Cells[1].Value.ToString());
                dataZ[i] = double.Parse(dataGridViewGraphValue.Rows[i].Cells[2].Value.ToString());
            }

            double[] dataY0 = new double[2]; dataY0[0] = double.MinValue;
            double[] dataX0 = new double[2];

            ObjectOptimizationClass tempobj = new ObjectOptimizationClass();
            tempobj.Setobjectoptimization(model.Secondrestruction);
            tempobj.SetValueVariableByNomber(1, dataY0[0]);
            for(double i = model.Lbvariableone; i <= model.Rbvariableone; i += 0.1)
            {
                tempobj.SetValueVariableByNomber(0, i);
                for (double j = model.Lbvariabletwo; j <= model.Rbvariabletwo; j += 0.1)
                {
                    tempobj.SetValueVariableByNomber(1, j);
                    if (Math.Round(tempobj.GetRezult().Value , 10) == model.Maxminsecondrestr)
                    {
                        if (dataY0[0] == double.MinValue)
                        {
                            dataX0[0] = i;
                            dataY0[0] = j;
                        }
                        else
                        {
                            dataX0[1] = i;
                            dataY0[1] = j;
                        }
                    }
                }
            }

            // создание объекта
            XYChart c = new XYChart(500, 460);

            // Установка размера внутренней картинки и цветов
            c.setPlotArea(30, 25, 400, 400, -1, -1, -1, unchecked((int)0xdd000000), -1);

            // Задание осей координат
            c.yAxis().setLinearScale(model.Lbvariabletwo, model.Rbvariabletwo, (model.Rbvariabletwo - model.Lbvariabletwo) / 10);
            c.xAxis().setLinearScale(model.Lbvariableone, model.Rbvariableone, (model.Rbvariableone - model.Lbvariableone) / 10);

            // Создание рабочего слоя
            ContourLayer layer = c.addContourLayer(dataX, dataY, dataZ);

            // Выделение цифр жирным
            layer.setContourLabelStyle("bold", 8, 0x000000);

            // Установка цветов
            layer.setContourLabelFormat("<*block,bgcolor=4FFFFFFF,margin=2 2 1 1*>{value}");

            // Переместите линии сетки перед контурным слоем
            c.getPlotArea().moveGridBefore(layer);

            // Устновка цветов
            ColorAxis cAxis = layer.setColorAxis(540, 25, ChartDirector.Chart.TopLeft, 300, ChartDirector.Chart.Right);

            // Добавление нового слоя и отрисовка на нем шагов метода оптимизации!!!!!!!!!!
            LineLayer layer0 = c.addLineLayer(dataY0, 0xff0000, "Country AAA");
            layer0.setXData(dataX0);
            layer0.setLineWidth(2);

            if (dtablerezultmethod.RowCount > 2)
            {
                dataXMethod = new double[dtablerezultmethod.RowCount];
                dataYMethod = new double[dtablerezultmethod.RowCount];

                for (int i = 0; i < dtablerezultmethod.RowCount - 1; i++)
                {
                    dataXMethod[i] = double.Parse(dtablerezultmethod.Rows[i].Cells[0].Value.ToString());
                    dataYMethod[i] = double.Parse(dtablerezultmethod.Rows[i].Cells[1].Value.ToString());
                }
                LineLayer layermethod = c.addLineLayer(dataYMethod, 0xff0000, "Country Method");
                layermethod.setXData(dataXMethod);
                layermethod.setLineWidth(2);
            }

            if (chartIndex == 1)
            {
                // Установка цветов
                int[] colorGradient = { 0x0044cc, 0xffffff, 0x00aa00 };
                cAxis.setColorGradient(false, colorGradient);
            }

            // Вывод графика
            viewer.Chart = c;

            // Вывод обозначений
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='<*cdml*><*font=bold*>X: {x|2}<*br*>Y: {y|2}<*br*>Z: {z|2}'");
        }
        public void createChart3D(WinChartViewer viewer, int chartIndex)
        {

            //double[] dataX = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double[] dataY = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double[] dataY = new double[dataGridViewGraphValue.RowCount];
            double[] dataX = new double[dataGridViewGraphValue.RowCount];
            double[] dataZ = new double[dataGridViewGraphValue.RowCount];

            for (int i = 0; i < dataGridViewGraphValue.RowCount - 1; i++)
            {
                dataX[i] = double.Parse(dataGridViewGraphValue.Rows[i].Cells[0].Value.ToString());
                dataY[i] = double.Parse(dataGridViewGraphValue.Rows[i].Cells[1].Value.ToString());
                dataZ[i] = double.Parse(dataGridViewGraphValue.Rows[i].Cells[2].Value.ToString());
            }

            SurfaceChart c = new SurfaceChart(600, 560);

            // Set the center of the plot region at (360, 245), and set width x depth x height to
            // 360 x 360 x 270 pixels
            c.setPlotRegion(320, 250, 400, 400, 350);

            // Set the elevation and rotation angles to 20 and 30 degrees
            c.setViewAngle(20, 15);

            // Set the data to use to plot the chart
            c.setData(dataX, dataY, dataZ);

            // Spline interpolate data to a 80 x 80 grid for a smooth surface
            c.setInterpolation(80, 80);

            // Set surface grid lines to semi-transparent black (dd000000)
            c.setSurfaceAxisGrid(unchecked((int)0xdd000000));

            // Set contour lines to semi-transparent white (80ffffff)
            c.setContourColor(unchecked((int)0x80ffffff));

            // Add a color axis (the legend) in which the left center is anchored at (645, 270). Set
            // the length to 200 pixels and the labels on the right side. Use smooth gradient
            // coloring.
            c.setColorAxis(645, 270, ChartDirector.Chart.Left, 200, ChartDirector.Chart.Right).setColorGradient();

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='<*cdml*><*font=bold*>X: {x|2}<*br*>Y: {y|2}<*br*>Z: {z|2}'");
        }

        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTableScren();
        }
        public void ShowTableScren()
        {
            this.Text = "Таблица";
            this.Width = 500;
            this.Height = 500;
            winChartViewer1.Visible = false;
            dtablerezultmethod.Visible = true;
        }

        private void сохранитьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Export", "data.xlsx");

            var wb = new XLWorkbook();
            var sh = wb.Worksheets.Add("Отчет");
            sh.Cell(1, 2).SetValue("Входные данные");
            sh.Cell(2, 1).SetValue("Задание:");
            sh.Cell(2, 2).SetValue(model.Name);
            sh.Cell(3, 1).SetValue("Описание задачи оптимизации:");
            sh.Cell(3, 2).SetValue(model.Textoptimizationproblem);
            sh.Cell(4, 1).SetValue("Целевая функция:");
            sh.Cell(4, 2).SetValue(model.Targertfuntion);

            sh.Cell(5, 2).SetValue("Ограничения");
            sh.Cell(6, 1).SetValue("Левая граница для " + namefirstparam + ":");
            sh.Cell(6, 2).SetValue(model.Lbvariableone);
            sh.Cell(7, 1).SetValue("Правая граница для " + namefirstparam + ":");
            sh.Cell(7, 2).SetValue(model.Rbvariableone);
            sh.Cell(8, 1).SetValue("Левая граница для " + namesecondparam + ":");
            sh.Cell(8, 2).SetValue(model.Lbvariabletwo);
            sh.Cell(9, 1).SetValue("Правая граница для " + namesecondparam + ":");
            sh.Cell(9, 2).SetValue(model.Rbvariabletwo);
            sh.Cell(10, 1).SetValue("Ограничение второго рода:");
            switch (model.Sinssecondrestruction)
            {
                case -1:
                    sh.Cell(10, 2).SetValue(model.Secondrestruction.Substring(4) + " ≤ " + model.Maxminsecondrestr);
                    break;
                case 0:
                    sh.Cell(10, 2).SetValue(model.Secondrestruction.Substring(4) + " = " + model.Maxminsecondrestr);
                    break;
                case 1:
                    sh.Cell(10, 2).SetValue(model.Secondrestruction.Substring(4) + " ≥ " + model.Maxminsecondrestr);
                    break;
            }

            sh.Cell(11, 1).SetValue("Выбранный метод решения:");
            sh.Cell(11, 2).SetValue(nameSelectedMethod);

            sh.Cell(12, 2).SetValue("Результаты расчета");
            sh.Cell(13, 1).SetValue("Первый параметр, " + namefirstparam + ":");
            sh.Cell(13, 2).SetValue(firstparamextr);
            sh.Cell(14, 1).SetValue("Второй параметр, " + namesecondparam + ":");
            sh.Cell(14, 2).SetValue(secondparamextr);
            sh.Cell(15, 1).SetValue("Экстремальное значение целовой функции, " + model.Targertfuntion.Substring(0, 1) + ":");
            sh.Cell(15, 2).SetValue(funcparamextr);

            sh.Cell(1, 4).SetValue("Первый параметр, " + namefirstparam);
            sh.Cell(1, 5).SetValue("Второй параметр, " + namesecondparam);
            sh.Cell(1, 6).SetValue("Значение целевой функции, " + model.Targertfuntion.Substring(0, 1));
            for (int i = 1; i <= dtablerezultmethod.Rows.Count - 1; i++)
            {
                sh.Cell(i + 1, 4).SetValue(dtablerezultmethod.Rows[i-1].Cells[0].Value.ToString());
                sh.Cell(i + 1, 5).SetValue(dtablerezultmethod.Rows[i-1].Cells[1].Value.ToString());
                sh.Cell(i + 1, 6).SetValue(dtablerezultmethod.Rows[i-1].Cells[2].Value.ToString());
            }
            try
            {
                wb.SaveAs(path);
            }
            catch
            {
                MessageBox.Show("Сохранение не удалось!");
            }
        }
    }
}
