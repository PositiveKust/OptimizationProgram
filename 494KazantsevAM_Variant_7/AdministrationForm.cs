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
    public partial class AdministrationForm : Form
    {
        int enteringuserid = -1;
        ApplicationContext db;
        List<OptimizationMethod> optimizationMethods;
        List<Model> optiomizationModels;
        List<User> users;
        Model tempmodel;
        User tempuser;
        OptimizationMethod tempmethod;
        MainForm mainForm;
        public AdministrationForm(MainForm mainForm)
        {
            InitializeComponent();
            this.Width = 230;
            this.Height = 230;
            this.Text = "Авторизация";
            toolStripButtonBack.Text = "Закрыть";
            this.mainForm = mainForm;
            db = new ApplicationContext();
            optiomizationModels = new List<Model>();
            optimizationMethods = new List<OptimizationMethod>();
            users = new List<User>();
            buttonUpdateUser.Enabled = false;
            buttonDeleteUser.Enabled = false;
            buttonUpdateMethod.Enabled = false;
            buttonDeleteMethod.Enabled = false;
            buttonUpdateModel.Enabled = false;
            buttonDeleteModel.Enabled = false;
            UploadingFromTheDatabase();
        }
        private void UploadingFromTheDatabase()
        {
            tableOptimizationMethods.ReadOnly = true;
            tableOptimizationModels.ReadOnly = true;
            tableUsers.ReadOnly = true;
            FillTableMethods();
            FillTableModels();
            FillTableUsers();
        }
        private void FillTableUsers()
        {
            users.Clear();
            tableUsers.Rows.Clear();
            if (db.Users.Count<User>() > 0)
            {
                users = db.Users.ToList();
                int i = 0;
                foreach (User user in users)
                {
                    tableUsers.Rows.Add();
                    tableUsers.Rows[i].Cells[0].Value = user.id;
                    tableUsers.Rows[i].Cells[1].Value = user.Name;
                    tableUsers.Rows[i].Cells[2].Value = user.Password;
                    i++;
                }
            }
        }
        private void FillTableMethods()
        {
            optimizationMethods.Clear();
            tableOptimizationMethods.Rows.Clear();
            db = new ApplicationContext();
            if (db.OptimizationMethods.Count<OptimizationMethod>() > 0)
            {
                optimizationMethods = db.OptimizationMethods.ToList();
                int i = 0;
                foreach (OptimizationMethod method in optimizationMethods)
                {
                    tableOptimizationMethods.Rows.Add();
                    tableOptimizationMethods.Rows[i].Cells[0].Value = method.id;
                    tableOptimizationMethods.Rows[i].Cells[1].Value = method.Name;
                    tableOptimizationMethods.Rows[i].Cells[2].Value = method.Active;
                    i++;
                }
            }
        }
        public void FillTableModels()
        {
            optiomizationModels.Clear();
            tableOptimizationModels.Rows.Clear();
            if (db.Models.Count<Model>() > 0)
            {
                optiomizationModels = db.Models.ToList();
                int i = 0;
                foreach (Model model in optiomizationModels)
                {
                    tableOptimizationModels.Rows.Add();
                    tableOptimizationModels.Rows[i].Cells[0].Value = model.id;
                    tableOptimizationModels.Rows[i].Cells[1].Value = model.Name;
                    tableOptimizationModels.Rows[i].Cells[2].Value = model.Textoptimizationproblem;
                    tableOptimizationModels.Rows[i].Cells[3].Value = model.Targertfuntion;
                    tableOptimizationModels.Rows[i].Cells[4].Value = model.Modeloptimization;
                    tableOptimizationModels.Rows[i].Cells[5].Value = model.Secondrestruction;
                    tableOptimizationModels.Rows[i].Cells[6].Value = model.Sinssecondrestruction;
                    tableOptimizationModels.Rows[i].Cells[7].Value = model.Maxminsecondrestr;
                    tableOptimizationModels.Rows[i].Cells[8].Value = model.Flagminmaxextremumserch;
                    tableOptimizationModels.Rows[i].Cells[9].Value = model.Lbvariableone;
                    tableOptimizationModels.Rows[i].Cells[10].Value = model.Rbvariableone;
                    tableOptimizationModels.Rows[i].Cells[11].Value = model.Lbvariabletwo;
                    tableOptimizationModels.Rows[i].Cells[12].Value = model.Rbvariabletwo;
                    tableOptimizationModels.Rows[i].Cells[13].Value = model.Accuracy;
                    i++;
                }
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            foreach (User user in users)
            {
                if(user.Name == textBoxUserName.Text && user.Password == textBoxPassword.Text)
                {
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    this.Text = "Добро пожаловать " + user.Name;
                    toolStripButtonBack.Text = "Выйти и закрыть";
                    this.Width = 820;
                    this.Height = 500;
                    authorizationGroupBox.Visible = false;
                    groupBoxAdministration.Visible = true;
                    enteringuserid = user.id;
                    tempmethod = new OptimizationMethod();
                    tempmodel = new Model();
                    tempuser = new User();
                }
                else
                {
                    if (user.Name == textBoxUserName.Text)
                    {
                        label2.ForeColor = Color.Red;
                    }
                    else
                    {
                        label1.ForeColor = Color.Red;
                        label2.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            if(enteringuserid != -1)
            {
                UploadingFromTheDatabase();
                enteringuserid = -1;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                this.Text = "Авторизация";
                toolStripButtonBack.Text = "Закрыть";
                this.Width = 230;
                this.Height = 230;
                authorizationGroupBox.Visible = true;
                groupBoxAdministration.Visible = false;
            }
            mainForm.Visible = true;
            this.Close();
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            AddNewObjectOptimization addNewObjectOptimization = new AddNewObjectOptimization(mainForm, this, 2);
            addNewObjectOptimization.Show();
            this.Visible = false;
        }

        private void tableOptimizationModels_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonUpdateModel.Text != "Сохранить") {
                label6.Text = "Номер задачи: " + tableOptimizationModels.Rows[tableOptimizationModels.CurrentCellAddress.Y].Cells[0].Value.ToString();
                tempmodel = db.Models.Find(int.Parse(tableOptimizationModels.Rows[tableOptimizationModels.CurrentCellAddress.Y].Cells[0].Value.ToString()));
                buttonUpdateModel.Enabled = true;
                buttonDeleteModel.Enabled = true;
            } 
        }

        private void buttonDeleteModel_Click(object sender, EventArgs e)
        {
            if (buttonDeleteModel.Text == "Удалить")
            {
                db.Models.Remove(tempmodel);
                db.SaveChanges();
                buttonUpdateModel.Enabled = false;
                buttonDeleteModel.Enabled = false;
                FillTableModels();
            }
            else
            {
                buttonAddModel.Enabled = true;
                buttonUpdateModel.Enabled = false;
                buttonDeleteModel.Enabled = false;
                buttonDeleteModel.Text = "Удалить";
                buttonUpdateModel.Text = "Изменить";
                tableOptimizationModels.ReadOnly = true;
                FillTableModels();
            }
            tempmodel = new Model();
            label6.Text = "Номер задачи: -";
        }
        
        private void tableOptimizationMethods_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonUpdateMethod.Text != "Сохранить" && buttonAddMethod.Text != "Подвтердить")
            {
                label9.Text = tableOptimizationMethods.Rows[tableOptimizationMethods.CurrentCellAddress.Y].Cells[0].Value.ToString();
                tempmethod = db.OptimizationMethods.Find(int.Parse(tableOptimizationMethods.Rows[tableOptimizationMethods.CurrentCellAddress.Y].Cells[0].Value.ToString()));
                buttonUpdateMethod.Enabled = true;
                buttonDeleteMethod.Enabled = true;
            }
        }
        private void tableUsers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonUpdateUser.Text != "Сохранить" && buttonAddUser.Text != "Подвтердить")
            {
                label8.Text = tableUsers.Rows[tableUsers.CurrentCellAddress.Y].Cells[0].Value.ToString();
                tempuser = db.Users.Find(int.Parse(tableUsers.Rows[tableUsers.CurrentCellAddress.Y].Cells[0].Value.ToString()));
                buttonUpdateUser.Enabled = true;
                buttonDeleteUser.Enabled = true;
            }
        }
        private void buttonUpdateModel_Click(object sender, EventArgs e)
        {
            if(buttonUpdateModel.Text == "Изменить")
            {
                buttonAddModel.Enabled = false;
                buttonDeleteModel.Text = "Назад";
                buttonUpdateModel.Text = "Сохранить";
                tableOptimizationModels.ReadOnly = false;
                tableOptimizationModels.Rows.Clear();

                tableOptimizationModels.Rows.Add();
                tableOptimizationModels.Rows[0].Cells[0].ReadOnly = true;
                tableOptimizationModels.Rows[0].Cells[0].Value = tempmodel.id;
                tableOptimizationModels.Rows[0].Cells[1].Value = tempmodel.Name;
                tableOptimizationModels.Rows[0].Cells[2].Value = tempmodel.Textoptimizationproblem;
                tableOptimizationModels.Rows[0].Cells[3].Value = tempmodel.Targertfuntion;
                tableOptimizationModels.Rows[0].Cells[4].Value = tempmodel.Modeloptimization;
                tableOptimizationModels.Rows[0].Cells[5].Value = tempmodel.Secondrestruction;
                tableOptimizationModels.Rows[0].Cells[6].Value = tempmodel.Sinssecondrestruction;
                tableOptimizationModels.Rows[0].Cells[7].Value = tempmodel.Maxminsecondrestr;
                tableOptimizationModels.Rows[0].Cells[8].Value = tempmodel.Flagminmaxextremumserch;
                tableOptimizationModels.Rows[0].Cells[9].Value = tempmodel.Lbvariableone;
                tableOptimizationModels.Rows[0].Cells[10].Value = tempmodel.Rbvariableone;
                tableOptimizationModels.Rows[0].Cells[11].Value = tempmodel.Lbvariabletwo;
                tableOptimizationModels.Rows[0].Cells[12].Value = tempmodel.Rbvariabletwo;
                tableOptimizationModels.Rows[0].Cells[13].Value = tempmodel.Accuracy;
            }
            else
            {
                tempmodel.Name = tableOptimizationModels.Rows[0].Cells[1].Value.ToString();
                tempmodel.Textoptimizationproblem = tableOptimizationModels.Rows[0].Cells[2].Value.ToString();
                tempmodel.Targertfuntion = tableOptimizationModels.Rows[0].Cells[3].Value.ToString();
                tempmodel.Modeloptimization = tableOptimizationModels.Rows[0].Cells[4].Value.ToString();
                tempmodel.Secondrestruction = tableOptimizationModels.Rows[0].Cells[5].Value.ToString();
                tempmodel.Sinssecondrestruction = int.Parse(tableOptimizationModels.Rows[0].Cells[6].Value.ToString());
                tempmodel.Maxminsecondrestr = double.Parse(tableOptimizationModels.Rows[0].Cells[7].Value.ToString());
                tempmodel.Flagminmaxextremumserch = bool.Parse(tableOptimizationModels.Rows[0].Cells[8].Value.ToString());
                tempmodel.Lbvariableone = double.Parse(tableOptimizationModels.Rows[0].Cells[9].Value.ToString());
                tempmodel.Rbvariableone = double.Parse(tableOptimizationModels.Rows[0].Cells[10].Value.ToString());
                tempmodel.Lbvariabletwo = double.Parse(tableOptimizationModels.Rows[0].Cells[11].Value.ToString());
                tempmodel.Rbvariabletwo = double.Parse(tableOptimizationModels.Rows[0].Cells[12].Value.ToString());
                tempmodel.Accuracy = double.Parse(tableOptimizationModels.Rows[0].Cells[13].Value.ToString());
                try {
                    if (db.Models.Find(tempmodel.id) != null)
                    {
                        db.Models.Find(tempmodel.id).Textoptimizationproblem = tempmodel.Textoptimizationproblem;
                        db.Models.Find(tempmodel.id).Targertfuntion = tempmodel.Targertfuntion;
                        db.Models.Find(tempmodel.id).Modeloptimization = tempmodel.Modeloptimization;
                        db.Models.Find(tempmodel.id).Secondrestruction = tempmodel.Secondrestruction;
                        db.Models.Find(tempmodel.id).Sinssecondrestruction = tempmodel.Sinssecondrestruction;
                        db.Models.Find(tempmodel.id).Maxminsecondrestr = tempmodel.Maxminsecondrestr;
                        db.Models.Find(tempmodel.id).Flagminmaxextremumserch = tempmodel.Flagminmaxextremumserch;
                        db.Models.Find(tempmodel.id).Lbvariableone = tempmodel.Lbvariableone;
                        db.Models.Find(tempmodel.id).Rbvariableone = tempmodel.Rbvariableone;
                        db.Models.Find(tempmodel.id).Lbvariabletwo = tempmodel.Lbvariabletwo;
                        db.Models.Find(tempmodel.id).Rbvariabletwo = tempmodel.Rbvariabletwo;
                        db.Models.Find(tempmodel.id).Accuracy = tempmodel.Accuracy;
                        db.Models.Find(tempmodel.id).Name = tempmodel.Name;
                        db.SaveChanges();
                    }

                    buttonAddModel.Enabled = true;
                    buttonUpdateModel.Enabled = false;
                    buttonDeleteModel.Enabled = false;
                    buttonDeleteModel.Text = "Удалить";
                    buttonUpdateModel.Text = "Изменить";
                    tableOptimizationModels.ReadOnly = true;
                    tempmodel = new Model();
                    label6.Text = "Номер задачи: -";
                    db.SaveChanges();
                    FillTableModels();
                }
                catch
                {
                    MessageBox.Show("Был неправильно введен один из параметров задачи оптимизации!", "Возникла проблема с сохранением!");
                    buttonAddModel.Enabled = true;
                    buttonUpdateModel.Enabled = false;
                    buttonDeleteModel.Enabled = false;
                    buttonDeleteModel.Text = "Удалить";
                    buttonUpdateModel.Text = "Изменить";
                    tableOptimizationModels.ReadOnly = true;
                    tempmodel = new Model();
                    label6.Text = "Номер задачи: -";
                    FillTableModels();
                }
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (buttonDeleteUser.Text == "Удалить")
            {
                db.Users.Remove(tempuser);
                buttonUpdateUser.Enabled = false;
                buttonDeleteUser.Enabled = false;
                if(tempuser.id == enteringuserid)
                {
                    authorizationGroupBox.Visible = true;
                    groupBoxAdministration.Visible = false;
                    this.Width = 230;
                    this.Height = 230;
                    this.Text = "Авторизация";
                    toolStripButtonBack.Text = "Закрыть";
                }
                db.SaveChanges();
                FillTableUsers();
            }
            else
            {
                buttonAddUser.Enabled = true;
                buttonUpdateUser.Enabled = false;
                buttonDeleteUser.Enabled = false;
                buttonAddUser.Text = "Добавить";
                buttonDeleteUser.Text = "Удалить";
                buttonUpdateUser.Text = "Изменить";
                tableUsers.ReadOnly = true;
                FillTableUsers();
            }
            tempuser = new User();
            label8.Text = "-";
        }

        private void buttonDeleteMethod_Click(object sender, EventArgs e)
        {
            if (buttonDeleteMethod.Text == "Удалить")
            {
                db.OptimizationMethods.Remove(tempmethod);
                tempmethod = new OptimizationMethod();
                label9.Text = "-";
                buttonUpdateMethod.Enabled = false;
                buttonDeleteMethod.Enabled = false;
                db.SaveChanges();
                FillTableMethods();
            }
            else
            {
                buttonAddMethod.Enabled = true;
                buttonUpdateMethod.Enabled = false;
                buttonDeleteMethod.Enabled = false;
                buttonAddMethod.Text = "Добавить";
                buttonDeleteMethod.Text = "Удалить";
                buttonUpdateMethod.Text = "Изменить";
                tableOptimizationMethods.ReadOnly = true;
                FillTableMethods();
            }
            tempmethod = new OptimizationMethod();
            label9.Text = "-";
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            if (buttonUpdateUser.Text == "Изменить")
            {
                buttonAddUser.Enabled = false;
                buttonDeleteUser.Text = "Назад";
                buttonUpdateUser.Text = "Сохранить";
                tableUsers.ReadOnly = false;
                tableUsers.Rows.Clear();

                tableUsers.Rows.Add();
                tableUsers.Rows[0].Cells[0].ReadOnly = true;
                tableUsers.Rows[0].Cells[0].Value = tempuser.id;
                tableUsers.Rows[0].Cells[1].Value = tempuser.Name;
                tableUsers.Rows[0].Cells[2].Value = tempuser.Password;
            }
            else
            {
                tempuser.Name = tableUsers.Rows[0].Cells[1].Value.ToString();
                tempuser.Password = tableUsers.Rows[0].Cells[2].Value.ToString();
                try
                {
                    if (db.Users.Find(tempuser.id) != null)
                    {
                        db.Users.Find(tempuser.id).Name = tempuser.Name;
                        db.Users.Find(tempuser.id).Password = tempuser.Password;
                        db.SaveChanges();
                    }

                    buttonAddUser.Enabled = true;
                    buttonUpdateUser.Enabled = false;
                    buttonDeleteUser.Enabled = false;
                    buttonDeleteUser.Text = "Удалить";
                    buttonUpdateUser.Text = "Изменить";
                    tableUsers.ReadOnly = true;
                    tempuser = new User();
                    label8.Text = "-";
                    db.SaveChanges();
                    FillTableUsers();
                }
                catch
                {
                    MessageBox.Show("Был неправильно введен один из параметров пользователя!", "Возникла проблема с сохранением!");
                    buttonAddUser.Enabled = true;
                    buttonUpdateUser.Enabled = false;
                    buttonDeleteUser.Enabled = false;
                    buttonDeleteUser.Text = "Удалить";
                    buttonUpdateUser.Text = "Изменить";
                    tableUsers.ReadOnly = true;
                    tempuser = new User();
                    label8.Text = "-";
                    FillTableUsers();
                }
            }
        }

        private void buttonUpdateMethod_Click(object sender, EventArgs e)
        {
            if (buttonUpdateMethod.Text == "Изменить")
            {
                buttonAddMethod.Enabled = false;
                buttonDeleteMethod.Text = "Назад";
                buttonUpdateMethod.Text = "Сохранить";
                tableOptimizationMethods.ReadOnly = false;
                tableOptimizationMethods.Rows.Clear();

                tableOptimizationMethods.Rows.Add();
                tableOptimizationMethods.Rows[0].Cells[0].ReadOnly = true;
                tableOptimizationMethods.Rows[0].Cells[0].Value = tempmethod.id;
                tableOptimizationMethods.Rows[0].Cells[1].Value = tempmethod.Name;
                tableOptimizationMethods.Rows[0].Cells[2].Value = tempmethod.Active;
            }
            else
            {
                tempmethod.Name = tableOptimizationMethods.Rows[0].Cells[1].Value.ToString();
                tempmethod.Active = tableOptimizationMethods.Rows[0].Cells[2].Value.ToString();
                try
                {
                    if (!(tempmethod.Active == "true" || tempmethod.Active == "false"))
                    {
                        MessageBox.Show("Параметр 'Активен' может принимать значения только 'true' или 'false'!");
                        throw new ArgumentNullException();
                    }
                    if (db.OptimizationMethods.Find(tempmethod.id) != null)
                    {
                        db.OptimizationMethods.Find(tempmethod.id).Name = tempmethod.Name;
                        db.OptimizationMethods.Find(tempmethod.id).Active = tempmethod.Active;
                        db.SaveChanges();
                    }

                    buttonAddMethod.Enabled = true;
                    buttonUpdateMethod.Enabled = false;
                    buttonDeleteMethod.Enabled = false;
                    buttonDeleteMethod.Text = "Удалить";
                    buttonUpdateMethod.Text = "Изменить";
                    tableOptimizationMethods.ReadOnly = true;
                    tempmethod = new OptimizationMethod();
                    label9.Text = "-";
                    db.SaveChanges();
                    FillTableMethods();
                }
                catch
                {
                    MessageBox.Show("Был неправильно введен один из параметров методов!", "Возникла проблема с сохранением!");
                    buttonAddMethod.Enabled = true;
                    buttonUpdateMethod.Enabled = false;
                    buttonDeleteMethod.Enabled = false;
                    buttonDeleteMethod.Text = "Удалить";
                    buttonUpdateMethod.Text = "Изменить";
                    tableOptimizationMethods.ReadOnly = true;
                    tempmethod = new OptimizationMethod();
                    label9.Text = "-";
                    FillTableMethods();
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (buttonAddUser.Text == "Добавить")
            {
                buttonUpdateUser.Enabled = false;
                buttonDeleteUser.Enabled = true;
                buttonDeleteUser.Text = "Назад";
                buttonAddUser.Text = "Подвтердить";
                tableUsers.ReadOnly = false;
                tableUsers.Rows.Clear();

                tempuser = new User();
                label8.Text = "-";
                tableUsers.Rows.Add();
                tableUsers.Rows[0].Cells[0].ReadOnly = true;
                tableUsers.Rows[0].Cells[0].Value = "№";
                tableUsers.Rows[0].Cells[1].Value = "Введите имя пользователя";
                tableUsers.Rows[0].Cells[2].Value = "Введите пароль";
            }
            else
            {
                tempuser.Name = tableUsers.Rows[0].Cells[1].Value.ToString();
                tempuser.Password = tableUsers.Rows[0].Cells[2].Value.ToString();
                try
                {
                    if (tempuser.Name == "" || tempuser.Password == "")
                    {
                        MessageBox.Show("Ошибка! Заполните поля!");
                        throw new ArgumentNullException();
                    }

                    db.Users.Add(tempuser);

                    buttonAddUser.Enabled = true;
                    buttonUpdateUser.Enabled = false;
                    buttonDeleteUser.Enabled = false;
                    buttonDeleteUser.Text = "Удалить";
                    buttonAddUser.Text = "Добавить";
                    tableUsers.ReadOnly = true;
                    tempuser = new User();
                    db.SaveChanges();
                    FillTableUsers();
                }
                catch
                {
                    MessageBox.Show("Был неправильно введен один из параметров пользователя!", "Возникла проблема с сохранением!");
                    buttonAddUser.Enabled = true;
                    buttonUpdateUser.Enabled = false;
                    buttonDeleteUser.Enabled = false;
                    buttonDeleteUser.Text = "Удалить";
                    buttonAddUser.Text = "Добавить";
                    tableUsers.ReadOnly = true;
                    tempuser = new User();
                    FillTableUsers();
                }
            }
        }

        private void buttonAddMethod_Click(object sender, EventArgs e)
        {
            if (buttonAddMethod.Text == "Добавить")
            {
                buttonUpdateMethod.Enabled = false;
                buttonDeleteMethod.Enabled = true;
                buttonDeleteMethod.Text = "Назад";
                buttonAddMethod.Text = "Подвтердить";
                tableOptimizationMethods.ReadOnly = false;
                tableOptimizationMethods.Rows.Clear();

                tempmethod = new OptimizationMethod();
                label9.Text = "-";
                tableOptimizationMethods.Rows.Add();
                tableOptimizationMethods.Rows[0].Cells[0].ReadOnly = true;
                tableOptimizationMethods.Rows[0].Cells[0].Value = "№";
                tableOptimizationMethods.Rows[0].Cells[1].Value = "Введите название метода";
                tableOptimizationMethods.Rows[0].Cells[2].Value = "false";
            }
            else
            {
                tempmethod.Name = tableOptimizationMethods.Rows[0].Cells[1].Value.ToString();
                tempmethod.Active = tableOptimizationMethods.Rows[0].Cells[2].Value.ToString();
                try
                {
                    if (tempmethod.Name == "" || tempmethod.Active == "" || !(tempmethod.Active == "true" || tempmethod.Active == "false"))
                    {
                        if(!(tempmethod.Active == "true" || tempmethod.Active == "false"))
                            MessageBox.Show("Параметр 'Активен' может принимать значения только 'true' или 'false'!");
                        else
                            MessageBox.Show("Ошибка! Заполните поля!");
                        throw new ArgumentNullException();
                    }

                    db.OptimizationMethods.Add(tempmethod);

                    buttonAddMethod.Enabled = true;
                    buttonUpdateMethod.Enabled = false;
                    buttonDeleteMethod.Enabled = false;
                    buttonDeleteMethod.Text = "Удалить";
                    buttonAddMethod.Text = "Добавить";
                    tableOptimizationMethods.ReadOnly = true;
                    tempmethod = new OptimizationMethod();
                    db.SaveChanges();
                    FillTableMethods();
                }
                catch
                {
                    MessageBox.Show("Был неправильно введен один из параметров методов!", "Возникла проблема с сохранением!");
                    buttonAddMethod.Enabled = true;
                    buttonUpdateMethod.Enabled = false;
                    buttonDeleteMethod.Enabled = false;
                    buttonDeleteMethod.Text = "Удалить";
                    buttonAddMethod.Text = "Добавить";
                    tableOptimizationMethods.ReadOnly = true;
                    tempmethod = new OptimizationMethod();
                    FillTableMethods();
                }
            }
        }
    }
}
