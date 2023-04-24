using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _494KazantsevAM_Variant_7
{
    public partial class MainForm : Form
    {
        ApplicationContext db;
        List<Model> modelOptiomizations;
        ObjectOptimizationClass targetfunction, modelOptForm, secondRestructions;
        Model selecttask;
        RezultCalculateForm rezultgraph;
        MethodSearchExtremumClass methodsearchext;
        AdministrationForm administration;
        List<OptimizationMethod> optimizationMethods;
        public MainForm()
        {
            InitializeComponent();
            db = new ApplicationContext();
            modelOptiomizations = new List<Model>();
            optimizationMethods = new List<OptimizationMethod>();
            modelOptForm = new ObjectOptimizationClass();
            secondRestructions = new ObjectOptimizationClass();
            targetfunction = new ObjectOptimizationClass();
            rezultgraph = new RezultCalculateForm(this, new Model());
            RefreshTask();
        }
        public void AddModel(Model model)
        {
            db.Models.Add(model);
            db.SaveChanges();
            RefreshTask();
        }

        private void RefreshTask()
        {
            modelOptiomizations.Clear();
            comboBoxTask.Items.Clear();
            if (db.Models.Count<Model>() > 0)
            {
                modelOptiomizations = db.Models.ToList();
                foreach (Model model in modelOptiomizations)
                    comboBoxTask.Items.Add(model.Name);
            }
            optimizationMethods.Clear();
            comboBoxMethodSerch.Items.Clear();
            if (db.OptimizationMethods.Count<OptimizationMethod>() > 0)
            {
                optimizationMethods = db.OptimizationMethods.ToList();
                foreach (OptimizationMethod optimizationMethod in optimizationMethods)
                    if(optimizationMethod.Active == "true")
                        comboBoxMethodSerch.Items.Add(optimizationMethod.Name);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string tempstr = "Программный комплекс решающий, поставленную задачу оптимизации." +
                "\nОрганизация: СПбгТИ(ТУ)\nГруппа: 494\nАвтор: Казанцев Александр Михайлович" +
                "\nСанкт-Петербург, 2022 г.";
            MessageBox.Show(tempstr, "О программе");
        }

        private void добавитьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewObjectOptimization addNewObjectOptimization = new AddNewObjectOptimization(this, administration, 1);
            addNewObjectOptimization.Show();
            rezultgraph.SetFlagSaveData(false);
            this.Visible = false;
        }

        private void buttondeletemodel_Click(object sender, EventArgs e)
        {
            rezultgraph.Visible = false;
            rezultgraph.SetFlagSaveData(false);
            rezultgraph.ClearRowGraphTable();
            rezultgraph.ClearRezultMethodTable();
            dataGridView1.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            comboBoxMethodSerch.Enabled = false;
            buttonCalculate.Enabled = false;
            buttondeletemodel.Enabled = false;
            db.Models.Remove(selecttask);
            selecttask = new Model();
            db.SaveChanges();
            RefreshTask();
            comboBoxTask.Text = "";
        }

        private void buttoncalculategraph_Click(object sender, EventArgs e)
        {
            bool flagerror = false;
            rezultgraph.SetFlagSaveData(false);
            label2.ForeColor = Color.Black;
            labelMethod.ForeColor = Color.Black;
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                if (dataGridView1.Rows[i].Cells[1].Value == null)
                {
                    flagerror = true;
                    break;
                }
                else if (dataGridView1.Rows[i].Cells[1].Value.ToString() != "")
                {
                    if (!double.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out double tempdouble)) 
                        flagerror = true; 
                }
                else
                    flagerror = true;
            }
            if (flagerror)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Значения множителей введены неправильно!";
            }
            else
            {
                rezultgraph.Close();
                rezultgraph = new RezultCalculateForm(this, selecttask);
                double[] tempdot3D = new double[] { 0, 0, 0 };
                rezultgraph.ClearRowGraphTable();
                rezultgraph.RenameColumnGraphTable(dataGridView2.Rows[0].Cells[1].Value.ToString(), 0);
                rezultgraph.RenameColumnGraphTable(dataGridView2.Rows[1].Cells[1].Value.ToString(), 1);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    modelOptForm.SetValueVariableByName(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                for(double tempX = double.Parse(dataGridView2.Rows[0].Cells[0].Value.ToString()); 
                    tempX <= double.Parse(dataGridView2.Rows[0].Cells[2].Value.ToString()); tempX += 1)
                {
                    modelOptForm.SetValueVariableByName(dataGridView2.Rows[0].Cells[1].Value.ToString(), tempX);
                    tempdot3D[0] = tempX;
                    for (double tempY = double.Parse(dataGridView2.Rows[1].Cells[0].Value.ToString());
                    tempY <= double.Parse(dataGridView2.Rows[1].Cells[2].Value.ToString()); tempY += 1)
                    {
                        tempdot3D[1] = tempY;
                        modelOptForm.SetValueVariableByName(dataGridView2.Rows[1].Cells[1].Value.ToString(), tempY);
                        targetfunction.SetValueVariableByName( modelOptForm.Getobjectoptimization(true)[0] + "", modelOptForm.GetRezult().Value );
                        tempdot3D[2] = targetfunction.GetRezult().Value;
                        rezultgraph.AddNewRowGraphTable(tempdot3D);
                    }
                }
                methodsearchext = new MethodSearchExtremumClass(modelOptForm, secondRestructions, selecttask.Maxminsecondrestr,
                    selecttask.Accuracy, selecttask.Sinssecondrestruction, selecttask.Flagminmaxextremumserch);
                methodsearchext.SetNumberVariable(2);
                methodsearchext.SetValueVariable(selecttask.Lbvariableone, selecttask.Rbvariableone, dataGridView2.Rows[0].Cells[1].Value.ToString(), 0);
                methodsearchext.SetValueVariable(selecttask.Lbvariabletwo, selecttask.Rbvariabletwo, dataGridView2.Rows[1].Cells[1].Value.ToString(), 1);
                methodsearchext.SetAccuracy(selecttask.Accuracy);
                buttonCalculate.Enabled = true;
                rezultgraph.Visible = true;
                if(comboBoxMethodSerch.SelectedIndex > -1)
                    rezultgraph.SetNameSelctedMethod(comboBoxMethodSerch.Items[comboBoxMethodSerch.SelectedIndex].ToString(),
                        dataGridView2.Rows[0].Cells[1].Value.ToString(), dataGridView2.Rows[1].Cells[1].Value.ToString(), true);
                else
                    rezultgraph.SetNameSelctedMethod("", dataGridView2.Rows[0].Cells[1].Value.ToString(), dataGridView2.Rows[1].Cells[1].Value.ToString(), true);
                rezultgraph.Show();
            }
        }
        private void Graph_Click(object sender, EventArgs e)
        {
            rezultgraph.ShowTableScren();
            rezultgraph.Show();
            rezultgraph.Visible = true;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool flagerror = false;
            rezultgraph.SetFlagSaveData(false);
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                if(dataGridView1.Rows[i].Cells[1].Value == null){
                    flagerror = true;
                    break;
                }
                else if (double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) != modelOptForm.GetValueVariableByName(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    flagerror = true;
            }
            if (comboBoxMethodSerch.Text != "" && !flagerror)
            {
                labelMethod.ForeColor = Color.Black;
                double[] extremum = new double[2];
                string message = "";
                switch (comboBoxMethodSerch.SelectedIndex)
                {
                    case 0:
                        extremum = methodsearchext.MethodAllValuesFunction(rezultgraph);
                        break;
                    case 1:
                        extremum = methodsearchext.MethodAllValuesUpdateStepFunction(rezultgraph);
                        break;
                    case 2:
                        extremum = methodsearchext.ComplexMethodBoxing(rezultgraph);
                        break;
                    case 3:
                        extremum = methodsearchext.MethodGeneticAlgorithm(rezultgraph);
                        break;
                }
                targetfunction.SetValueVariableByName(modelOptForm.Getobjectoptimization(true)[0] + "", extremum[2]);
                if (!selecttask.Flagminmaxextremumserch)
                    message += "Минимальное";
                else
                    message += "Максимальное";
                message += " значение целевой функции:\n" + targetfunction.GetRezult().ToString() + "\n";
                message += "При " + dataGridView2.Rows[0].Cells[1].Value.ToString() + " = " + extremum[0];
                message += " и " + dataGridView2.Rows[1].Cells[1].Value.ToString() + " = " + extremum[1] + "\n";
                MessageBox.Show(message, "Экстремум найден!");
                rezultgraph.SetNameSelctedMethod(comboBoxMethodSerch.Items[comboBoxMethodSerch.SelectedIndex].ToString(),
                    dataGridView2.Rows[0].Cells[1].Value.ToString(), dataGridView2.Rows[1].Cells[1].Value.ToString(), true);
                rezultgraph.SetExtremumValue(extremum[0], extremum[1], double.Parse(targetfunction.GetRezult().ToString()));
                rezultgraph.SetFlagSaveData(true);
            }
            else if (flagerror)
            {
                label2.ForeColor = Color.Red;
                buttonCalculate.Enabled = false;
                label2.Text = "Значения множителей введены неправильно!";
            }
            else
            {
                labelMethod.ForeColor = Color.Red;
                labelMethod.Text = "Вы не выбрали метод!";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonCalculate.Enabled = false;
            rezultgraph.SetFlagSaveData(false);
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rezultgraph.Visible = false;
            administration = new AdministrationForm(this);
            administration.Show();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rezultgraph.Close();
            this.Close();
        }

        private void buttonSetTaskOptimizatopn_Click(object sender, EventArgs e)
        {
            if (comboBoxTask.Text != "")
            {
                rezultgraph.Visible = false;
                rezultgraph.SetFlagSaveData(false);
                rezultgraph.ClearRowGraphTable();
                rezultgraph.ClearRezultMethodTable();
                labelTask.ForeColor = Color.Black;
                selecttask = modelOptiomizations[comboBoxTask.SelectedIndex];
                labelModelOptimization.Text = selecttask.Modeloptimization.Substring(4);
                richTextBox1.Text = selecttask.Textoptimizationproblem;
                targetfunction.Setobjectoptimization(selecttask.Targertfuntion);
                modelOptForm.Setobjectoptimization(selecttask.Modeloptimization);
                secondRestructions.Setobjectoptimization(selecttask.Secondrestruction);
                textBoxRestrictionsecondkind.Text = selecttask.Secondrestruction.Substring(4);
                textBoxBorderRestrictionsecondkind.Text = selecttask.Maxminsecondrestr.ToString();
                comboBoxSign.SelectedIndex = selecttask.Sinssecondrestruction + 1;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add();
                dataGridView2.Rows[0].Cells[0].Value = selecttask.Lbvariableone.ToString();
                dataGridView2.Rows[0].Cells[1].Value = secondRestructions.GetNameVariable(0);
                dataGridView2.Rows[0].Cells[2].Value = selecttask.Rbvariableone.ToString();
                dataGridView2.Rows.Add();
                dataGridView2.Rows[1].Cells[0].Value = selecttask.Lbvariabletwo.ToString();
                dataGridView2.Rows[1].Cells[1].Value = secondRestructions.GetNameVariable(1);
                dataGridView2.Rows[1].Cells[2].Value = selecttask.Rbvariabletwo.ToString();
                dataGridView1.Rows.Clear();
                for (int i = 0, temp = 0; i < modelOptForm.GetNumberVariable(); i++)
                {
                    if (modelOptForm.GetNameVariable(i) == secondRestructions.GetNameVariable(0) ||
                        modelOptForm.GetNameVariable(i) == secondRestructions.GetNameVariable(1))
                    {
                        temp++;
                        continue;
                    }
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i - temp].Cells[0].Value = modelOptForm.GetNameVariable(i);
                    dataGridView1.Rows[i - temp].Cells[1].Value = 1;
                }
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.Enabled = true;
                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
                comboBoxMethodSerch.Enabled = true;
                buttondeletemodel.Enabled = true;
                buttoncalculategraph.Enabled = true;
                rezultgraph.SetFlagSaveData(false);
                buttonCalculate.Enabled = false;
            }
            else
            {
                labelTask.ForeColor = Color.Red;
                labelTask.Text = "Вы не выбрали задание!";
                dataGridView1.Enabled = false;
                comboBoxMethodSerch.Enabled = false;
                buttonCalculate.Enabled = false;
                rezultgraph.SetFlagSaveData(false);
            }
        }
    }
}
