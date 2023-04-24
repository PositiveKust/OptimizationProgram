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
    public partial class AddNewObjectOptimization : Form
    {
        ObjectOptimizationClass targetfunction, objectOptimization, secondRestructions;
        int flagnewobjectoptimization = 0, numberForm = 0;
        MainForm mainForm;
        AdministrationForm administrationForm;
        public AddNewObjectOptimization(MainForm mainForm, AdministrationForm administrationForm, int numberForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.administrationForm = administrationForm;
            this.numberForm = numberForm;
            objectOptimization = new ObjectOptimizationClass();
            secondRestructions = new ObjectOptimizationClass();
            targetfunction = new ObjectOptimizationClass();
            textBoxObjectOptimization.Text = objectOptimization.Getobjectoptimization(true);
            buttonBack.Enabled = false;
            checkedChangeVariable.Visible = false;
            labelcheckedChangeVariable.Visible = true;
            labelValueConstVariable.Visible = false;
            labelSetObjectOptimization.Visible = true;
            dataGridLeftandRightBoardVariable.Visible = false;
            textBoxBorderRestrictionsecondkind.Visible = false;
            comboBoxSign.Visible = false;
            comboBoxSign.SelectedItem = "≤";
            textBoxRestrictionsecondkind.Visible = false;
            labelAlinformation.Visible = false;
            textBoxObjectOptimization.Visible = false;
            Closing += ExecuteOnClosing;
        }
        void ExecuteOnClosing(object sender, CancelEventArgs e)
        {
            if (numberForm == 1)
                mainForm.Visible = true;
            else if (numberForm == 2)
                administrationForm.Visible = true;
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numberForm == 1)
                mainForm.Visible = true;
            else if(numberForm == 2)
                administrationForm.Visible = true;
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch (flagnewobjectoptimization)
            {
                case 0:
                    if (richTextBox1.Text != "" && textBoxNameOptimization.Text != "" && textBoxAccuracy.Text != "" &&
                        double.TryParse(textBoxAccuracy.Text, out double temp) && comboBoxmimmax.Text != "")
                    {
                        label1.Text = "Введите целевую функцию";
                        richTextBox1.Visible = false;
                        flagnewobjectoptimization++;
                        label1.ForeColor = Color.Black;
                        labelAccuracy.ForeColor = Color.Black;
                        labelcheckedChangeVariable.ForeColor = Color.Black;
                        labelSetObjectOptimization.Visible = true;
                        labelcheckedChangeVariable.Visible = false;
                        textBoxNameOptimization.Visible = false;
                        textBoxObjectOptimization.Visible = true;
                        labelAccuracy.Visible = false;
                        textBoxAccuracy.Visible = false;
                        buttonBack.Enabled = true;
                        comboBoxmimmax.Visible = false;
                        labelSetObjectOptimization.Text = "Введите математическую модель";
                    }
                    else if(textBoxNameOptimization.Text == "")
                    {
                        label1.Text = "Наименование задачи оптимизации не было введено!";
                        label1.ForeColor = Color.Red;
                    }
                    else if (richTextBox1.Text == "")
                    {
                        labelcheckedChangeVariable.Text = "Текст задачи оптимизации не был введен!";
                        labelcheckedChangeVariable.ForeColor = Color.Red;
                    }
                    else if (comboBoxmimmax.Text == "")
                    {
                        labelSetObjectOptimization.Text = "Выберите вид экстремума для задачи!";
                        labelSetObjectOptimization.ForeColor = Color.Red;
                    }
                    else
                    {
                        labelAccuracy.Text = "Точность была введена не верно!";
                        labelAccuracy.ForeColor = Color.Red;
                    }
                    break;
                case 1:
                    label1.ForeColor = Color.Black;
                    labelSetObjectOptimization.ForeColor = Color.Black;
                    if (targetfunction.Setobjectoptimization(textBoxTargetFunction.Text) &&
                        (objectOptimization.Setobjectoptimization(textBoxObjectOptimization.Text)) &&
                        targetfunction.GetNameVariable(0) == objectOptimization.Getobjectoptimization(true)[0].ToString())
                    {
                        if (targetfunction.GetNameVariable(0) == objectOptimization.Getobjectoptimization(true)[0].ToString())
                        {
                            checkedChangeVariable.Visible = true;
                            flagnewobjectoptimization++;
                            labelcheckedChangeVariable.ForeColor = Color.Black;
                            label1.ForeColor = Color.Black;
                            labelSetObjectOptimization.ForeColor = Color.Black;
                            checkedChangeVariable.Items.Clear();
                            labelcheckedChangeVariable.Text = "Выберите параметры целевой функции.";
                            labelcheckedChangeVariable.Visible = true;
                            for (int i = 0; i < objectOptimization.GetNumberVariable(); i++)
                            {
                                checkedChangeVariable.Items.Add(objectOptimization.GetNameVariable(i));
                            }
                        }
                        else
                            label1.ForeColor = Color.Red;
                    }
                    if (!targetfunction.Setobjectoptimization(textBoxTargetFunction.Text))
                        label1.ForeColor = Color.Red;
                    if(targetfunction.GetNameVariable(0) != objectOptimization.Getobjectoptimization(true)[0].ToString())
                        label1.ForeColor = Color.Red;
                    if (!objectOptimization.Setobjectoptimization(textBoxObjectOptimization.Text))
                        labelSetObjectOptimization.ForeColor = Color.Red;
                    break;
                case 2:
                    bool flagnext1 = true;
                    if (checkedChangeVariable.CheckedItems.Count != 2)
                    {
                        labelcheckedChangeVariable.Text = "Выберете две переменные, являющиеся параметрами целевой функции.";
                        labelcheckedChangeVariable.ForeColor = Color.Red;
                        flagnext1 = false;
                    }
                    if (flagnext1)
                    {
                        labelValueConstVariable.Visible = true;
                        labelcheckedChangeVariable.Text = "Ограничения первого рода.";
                        labelcheckedChangeVariable.ForeColor = Color.Black;
                        labelValueConstVariable.Text = "Ограничение второго рода.";
                        labelValueConstVariable.ForeColor = Color.Black;
                        checkedChangeVariable.Visible = false;
                        dataGridLeftandRightBoardVariable.Visible = true;
                        dataGridLeftandRightBoardVariable.ReadOnly = false;
                        dataGridLeftandRightBoardVariable.Rows.Clear();
                        for (int i = 0; i < checkedChangeVariable.CheckedItems.Count; i++)
                            dataGridLeftandRightBoardVariable.Rows.Add(new Object[] { "", checkedChangeVariable.CheckedItems[i].ToString(), "" });
                        textBoxBorderRestrictionsecondkind.Visible = true;
                        comboBoxSign.Visible = true;
                        textBoxRestrictionsecondkind.Visible = true;
                        textBoxBorderRestrictionsecondkind.Enabled = true;
                        comboBoxSign.Enabled = true;
                        textBoxRestrictionsecondkind.Enabled = true;
                        flagnewobjectoptimization++;
                    }
                    break;
                case 3:
                    bool flagnext = true;
                    labelcheckedChangeVariable.Text = "Ограничения первого рода.";
                    labelcheckedChangeVariable.ForeColor = Color.Black;
                    labelValueConstVariable.Text = "Ограничение второго рода.";
                    labelValueConstVariable.ForeColor = Color.Black;
                    for (int i = 0; i < checkedChangeVariable.CheckedItems.Count; i++) {
                        if ( (!double.TryParse(dataGridLeftandRightBoardVariable.Rows[i].Cells[0].Value.ToString(), out double tempnum2)) || (!double.TryParse(dataGridLeftandRightBoardVariable.Rows[i].Cells[2].Value.ToString(), out double tempnum3)) )
                        {
                            flagnext = false;
                            labelcheckedChangeVariable.Text = "Не все ограничения введены, или\nони введены неправильно.";
                            labelcheckedChangeVariable.ForeColor = Color.Red;
                        }
                        else
                        {
                            if( double.Parse(dataGridLeftandRightBoardVariable.Rows[i].Cells[0].Value.ToString()) > double.Parse(dataGridLeftandRightBoardVariable.Rows[i].Cells[2].Value.ToString()))
                            {
                                flagnext = false;
                                labelcheckedChangeVariable.Text = "Не все ограничения введены, или\nони введены неправильно.";
                                labelcheckedChangeVariable.ForeColor = Color.Red;
                            }
                        }
                    }
                    if (!secondRestructions.Setobjectoptimization("T = " + textBoxRestrictionsecondkind.Text) ||
                        !secondRestructions.ExistVariableByName(dataGridLeftandRightBoardVariable.Rows[0].Cells[1].Value.ToString()) ||
                        !secondRestructions.ExistVariableByName(dataGridLeftandRightBoardVariable.Rows[1].Cells[1].Value.ToString()) ||
                        secondRestructions.GetNumberVariable() != 2)
                    {
                        labelValueConstVariable.Text = "Формула ограничения введена неверно.";
                        labelValueConstVariable.ForeColor = Color.Red;
                        flagnext = false;
                    }
                    if(!double.TryParse(textBoxBorderRestrictionsecondkind.Text, out double tempnum))
                    {
                        labelValueConstVariable.Text = "Не введено ограничение.";
                        labelValueConstVariable.ForeColor = Color.Red;
                        flagnext = false;
                    }
                    if (flagnext)
                    {
                        dataGridLeftandRightBoardVariable.ReadOnly = true;
                        textBoxBorderRestrictionsecondkind.Enabled = false;
                        comboBoxSign.Enabled = false;
                        textBoxRestrictionsecondkind.Enabled = false;
                        labelAlinformation.Visible = true;
                        buttonNext.Text = "Подтвердить сохранение";
                        flagnewobjectoptimization++;
                    }
                    break;
                case 4:
                    panelseObjectoptimization.Visible = false;

                    int tempflag = -2;
                    switch (comboBoxSign.Text)
                    {
                        case "≤":
                            tempflag = -1;
                            break;
                        case "=":
                            tempflag = 0;
                            break;
                        case "≥":
                            tempflag = 1;
                            break;
                    }
                    bool tempfunc = true;
                    if (comboBoxmimmax.Text == "минимума")
                        tempfunc = false;
                    // Сохранение нового задания в базу данных
                    Model model = new Model(textBoxNameOptimization.Text, richTextBox1.Text, targetfunction.Getobjectoptimization(true), objectOptimization.Getobjectoptimization(true),
                        secondRestructions.Getobjectoptimization(true), tempflag, double.Parse(textBoxBorderRestrictionsecondkind.Text),
                        double.Parse(dataGridLeftandRightBoardVariable.Rows[0].Cells[0].Value.ToString()), double.Parse(dataGridLeftandRightBoardVariable.Rows[0].Cells[2].Value.ToString()),
                        double.Parse(dataGridLeftandRightBoardVariable.Rows[1].Cells[0].Value.ToString()), double.Parse(dataGridLeftandRightBoardVariable.Rows[1].Cells[2].Value.ToString()),
                        double.Parse(textBoxAccuracy.Text), tempfunc);
                    mainForm.AddModel(model);
                    this.Visible = false;
                    MessageBox.Show("Задание успешно загружено!");
                    if (numberForm == 1)
                        mainForm.Visible = true;
                    else if (numberForm == 2)
                    {
                        administrationForm.FillTableModels();
                        administrationForm.Visible = true;
                    }
                    this.Close();
                    break;
            }
        }

        /*public bool AddNewRowDataGridViewRezult(params string[] parametres)
        {
            bool flag = false;
            if (parametres.Length == dataGridViewRezultCalculateMathod.Columns.Count)
            {
                int tempnumber = dataGridViewRezultCalculateMathod.Rows.Count - 1;
                dataGridViewRezultCalculateMathod.Rows.Add();
                for (int i = 0; i < dataGridViewRezultCalculateMathod.Columns.Count; i++)
                {
                    dataGridViewRezultCalculateMathod.Rows[tempnumber].Cells[i].Value = parametres[i];
                }
                flag = true;
            }
            return flag;
        } Для формы с расчетами*/

        /*private void ChangeNumbersRowsdataGrid()
        {
            if (checkedChangeVariable.CheckedItems.Count == 0)
                return;
            dataGridViewSetConstVariableValue.Rows.Clear(); int minusi = 0;
            for (int i = 0; i < objectOptimization.GetNumberVariable(); i++)
            {
                if (minusi < checkedChangeVariable.CheckedItems.Count)
                {
                    if (checkedChangeVariable.CheckedItems[minusi].ToString() == objectOptimization.GetNameVariable(i))
                    {
                        minusi++;
                        continue;
                    }
                }
                dataGridViewSetConstVariableValue.Rows.Add(new Object[] { objectOptimization.GetNameVariable(i), "" });
            }
        }*/

        private void buttonBack_Click(object sender, EventArgs e)
        {
            switch (flagnewobjectoptimization)
            {
                case 1:
                    labelcheckedChangeVariable.Text = "Введите полный текст задания";
                    label1.Text = "Введите название задачи оптимизации";
                    labelSetObjectOptimization.Text = "Задача поиска в целевой функции";
                    comboBoxmimmax.Visible = true;
                    labelSetObjectOptimization.Visible = true;
                    richTextBox1.Visible = true;
                    textBoxNameOptimization.Visible = true;
                    textBoxObjectOptimization.Visible = false;
                    labelcheckedChangeVariable.Visible = true;
                    buttonBack.Enabled = false;
                    labelAccuracy.Visible = true;
                    textBoxAccuracy.Visible = true;
                    break;
                case 2:
                    textBoxObjectOptimization.Enabled = true;
                    checkedChangeVariable.Visible = false;
                    labelcheckedChangeVariable.Visible = false;
                    labelValueConstVariable.Visible = false;
                    break;
                case 3:
                    buttonNext.Text = "Далее";
                    labelcheckedChangeVariable.Text = "Выберите изменяеммые переменные.";
                    labelcheckedChangeVariable.ForeColor = Color.Black;
                    textBoxObjectOptimization.Enabled = false;
                    dataGridLeftandRightBoardVariable.Visible = false;
                    buttonBack.Enabled = true;
                    checkedChangeVariable.Visible = true;
                    labelcheckedChangeVariable.Visible = true;
                    labelValueConstVariable.Visible = false;
                    textBoxBorderRestrictionsecondkind.Visible = false;
                    comboBoxSign.Visible = false;
                    textBoxRestrictionsecondkind.Visible = false;
                    break;
                case 4:
                    dataGridLeftandRightBoardVariable.ReadOnly = false;
                    textBoxBorderRestrictionsecondkind.Enabled = true;
                    comboBoxSign.Enabled = true;
                    textBoxRestrictionsecondkind.Enabled = true;
                    labelAlinformation.Visible = false;
                    buttonNext.Text = "Далее";
                    break;
            }
            flagnewobjectoptimization--;
        }

        /*private void buttonCalculateMathod_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPossibleSearchError.Text, out double tempnum))
            {
                if (double.Parse(textBoxPossibleSearchError.Text) > 0.0001)
                {
                    methodextremum.SetAccuracy(double.Parse(textBoxPossibleSearchError.Text));
                    labelAccuracy.Text = "Введите погрешность поиска";
                    labelAccuracy.ForeColor = Color.Black;
                    if (comboBoxExtremumSearch.Text == "Минимум")
                        methodextremum.SetFlagMinMax(false);
                    else
                        methodextremum.SetFlagMinMax(true);
                    dataGridViewRezultCalculateMathod.Rows.Clear();
                    rezultmethodworkToolStripMenuItem.Visible = true;
                    double[] extremum;
                    string text;
                    switch (comboBoxMethodSearchExtremum.Items[comboBoxMethodSearchExtremum.SelectedIndex])
                    {
                        case "Пройтись по всем значениям":
                            extremum = methodextremum.MethodAllValuesFunction(this);
                            text = "";
                            for(int i = 0; i < checkedChangeVariable.CheckedItems.Count; i++)
                            {
                                text += checkedChangeVariable.CheckedItems[i] + " = " + extremum[i] + ";\n";
                            }
                            MessageBox.Show(text + "Экстремум функции = " + extremum[checkedChangeVariable.CheckedItems.Count], "Экстремум найден");
                            IllustrationOfRestrictions(extremum);
                            break;
                        case "Метод золотого сечения":
                            extremum = methodextremum.MethodGoldenRatio(this);
                            text = "";
                            for (int i = 0; i < checkedChangeVariable.CheckedItems.Count; i++)
                            {
                                text += checkedChangeVariable.CheckedItems[i] + " = " + extremum[i] + ";\n";
                            }
                            MessageBox.Show(text + "Экстремум функции = " + extremum[checkedChangeVariable.CheckedItems.Count], "Экстремум найден");
                            IllustrationOfRestrictions(extremum);
                            break;
                        case "Метод с использованием чисел Фибоначче":
                            extremum = methodextremum.MethodFibonachiNumber(this);
                            text = "";
                            for (int i = 0; i < checkedChangeVariable.CheckedItems.Count; i++)
                            {
                                text += checkedChangeVariable.CheckedItems[i] + " = " + extremum[i] + ";\n";
                            }
                            MessageBox.Show(text + "Экстремум функции = " + extremum[checkedChangeVariable.CheckedItems.Count], "Экстремум найден");
                            IllustrationOfRestrictions(extremum);
                            break;
                    }
                }
                else
                {
                    labelAccuracy.Text = "Точность слишком велека. \nУменьшите её хотя бы до 0,0002.";
                    labelAccuracy.ForeColor = Color.Red;
                }
            }
            else
            {
                labelAccuracy.Text = "Введите погрешность поиска правильно!";
                labelAccuracy.ForeColor = Color.Red;
            }
        }*/
    }
}
