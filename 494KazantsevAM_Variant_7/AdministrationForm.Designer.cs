
namespace _494KazantsevAM_Variant_7
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorizationGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.groupBoxAdministration = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDeleteMethod = new System.Windows.Forms.Button();
            this.buttonUpdateMethod = new System.Windows.Forms.Button();
            this.buttonAddMethod = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteModel = new System.Windows.Forms.Button();
            this.buttonUpdateModel = new System.Windows.Forms.Button();
            this.buttonAddModel = new System.Windows.Forms.Button();
            this.tableOptimizationMethods = new System.Windows.Forms.DataGridView();
            this.idMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableOptimizationModels = new System.Windows.Forms.DataGridView();
            this.idModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetfunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloptimozation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondrestruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinssecondrestruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxminsecondrestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagminmaxextremumserch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbvariableone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbvariableone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbvariabletwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbvariabletwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.authorizationGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxAdministration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOptimizationMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOptimizationModels)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationGroupBox
            // 
            this.authorizationGroupBox.Controls.Add(this.textBoxPassword);
            this.authorizationGroupBox.Controls.Add(this.textBoxUserName);
            this.authorizationGroupBox.Controls.Add(this.label2);
            this.authorizationGroupBox.Controls.Add(this.label1);
            this.authorizationGroupBox.Controls.Add(this.buttonEnter);
            this.authorizationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.authorizationGroupBox.Name = "authorizationGroupBox";
            this.authorizationGroupBox.Size = new System.Drawing.Size(260, 224);
            this.authorizationGroupBox.TabIndex = 0;
            this.authorizationGroupBox.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(44, 112);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(188, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(44, 53);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(188, 22);
            this.textBoxUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя пользователя:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(44, 155);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(168, 49);
            this.buttonEnter.TabIndex = 0;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonBack.Text = "Закрыть";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // groupBoxAdministration
            // 
            this.groupBoxAdministration.Controls.Add(this.label9);
            this.groupBoxAdministration.Controls.Add(this.buttonDeleteMethod);
            this.groupBoxAdministration.Controls.Add(this.buttonUpdateMethod);
            this.groupBoxAdministration.Controls.Add(this.buttonAddMethod);
            this.groupBoxAdministration.Controls.Add(this.label10);
            this.groupBoxAdministration.Controls.Add(this.label8);
            this.groupBoxAdministration.Controls.Add(this.buttonDeleteUser);
            this.groupBoxAdministration.Controls.Add(this.buttonUpdateUser);
            this.groupBoxAdministration.Controls.Add(this.buttonAddUser);
            this.groupBoxAdministration.Controls.Add(this.label7);
            this.groupBoxAdministration.Controls.Add(this.label6);
            this.groupBoxAdministration.Controls.Add(this.buttonDeleteModel);
            this.groupBoxAdministration.Controls.Add(this.buttonUpdateModel);
            this.groupBoxAdministration.Controls.Add(this.buttonAddModel);
            this.groupBoxAdministration.Controls.Add(this.tableOptimizationMethods);
            this.groupBoxAdministration.Controls.Add(this.tableUsers);
            this.groupBoxAdministration.Controls.Add(this.label5);
            this.groupBoxAdministration.Controls.Add(this.label4);
            this.groupBoxAdministration.Controls.Add(this.tableOptimizationModels);
            this.groupBoxAdministration.Controls.Add(this.label3);
            this.groupBoxAdministration.Location = new System.Drawing.Point(12, 30);
            this.groupBoxAdministration.Name = "groupBoxAdministration";
            this.groupBoxAdministration.Size = new System.Drawing.Size(1030, 504);
            this.groupBoxAdministration.TabIndex = 2;
            this.groupBoxAdministration.TabStop = false;
            this.groupBoxAdministration.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "-";
            // 
            // buttonDeleteMethod
            // 
            this.buttonDeleteMethod.Location = new System.Drawing.Point(884, 444);
            this.buttonDeleteMethod.Name = "buttonDeleteMethod";
            this.buttonDeleteMethod.Size = new System.Drawing.Size(117, 51);
            this.buttonDeleteMethod.TabIndex = 18;
            this.buttonDeleteMethod.Text = "Удалить";
            this.buttonDeleteMethod.UseVisualStyleBackColor = true;
            this.buttonDeleteMethod.Click += new System.EventHandler(this.buttonDeleteMethod_Click);
            // 
            // buttonUpdateMethod
            // 
            this.buttonUpdateMethod.Location = new System.Drawing.Point(757, 444);
            this.buttonUpdateMethod.Name = "buttonUpdateMethod";
            this.buttonUpdateMethod.Size = new System.Drawing.Size(121, 51);
            this.buttonUpdateMethod.TabIndex = 17;
            this.buttonUpdateMethod.Text = "Изменить";
            this.buttonUpdateMethod.UseVisualStyleBackColor = true;
            this.buttonUpdateMethod.Click += new System.EventHandler(this.buttonUpdateMethod_Click);
            // 
            // buttonAddMethod
            // 
            this.buttonAddMethod.Location = new System.Drawing.Point(627, 444);
            this.buttonAddMethod.Name = "buttonAddMethod";
            this.buttonAddMethod.Size = new System.Drawing.Size(124, 51);
            this.buttonAddMethod.TabIndex = 16;
            this.buttonAddMethod.Text = "Добавить";
            this.buttonAddMethod.UseVisualStyleBackColor = true;
            this.buttonAddMethod.Click += new System.EventHandler(this.buttonAddMethod_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Номер метода:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "-";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(400, 444);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(103, 51);
            this.buttonDeleteUser.TabIndex = 13;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Location = new System.Drawing.Point(291, 444);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(103, 51);
            this.buttonUpdateUser.TabIndex = 12;
            this.buttonUpdateUser.Text = "Изменить";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(173, 444);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(112, 51);
            this.buttonAddUser.TabIndex = 11;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Номер пользователя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(841, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Номер задачи: -";
            // 
            // buttonDeleteModel
            // 
            this.buttonDeleteModel.Location = new System.Drawing.Point(841, 217);
            this.buttonDeleteModel.Name = "buttonDeleteModel";
            this.buttonDeleteModel.Size = new System.Drawing.Size(160, 41);
            this.buttonDeleteModel.TabIndex = 8;
            this.buttonDeleteModel.Text = "Удалить";
            this.buttonDeleteModel.UseVisualStyleBackColor = true;
            this.buttonDeleteModel.Click += new System.EventHandler(this.buttonDeleteModel_Click);
            // 
            // buttonUpdateModel
            // 
            this.buttonUpdateModel.Location = new System.Drawing.Point(841, 152);
            this.buttonUpdateModel.Name = "buttonUpdateModel";
            this.buttonUpdateModel.Size = new System.Drawing.Size(160, 41);
            this.buttonUpdateModel.TabIndex = 7;
            this.buttonUpdateModel.Text = "Изменить";
            this.buttonUpdateModel.UseVisualStyleBackColor = true;
            this.buttonUpdateModel.Click += new System.EventHandler(this.buttonUpdateModel_Click);
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.Location = new System.Drawing.Point(841, 91);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Size = new System.Drawing.Size(160, 40);
            this.buttonAddModel.TabIndex = 6;
            this.buttonAddModel.Text = "Добавить";
            this.buttonAddModel.UseVisualStyleBackColor = true;
            this.buttonAddModel.Click += new System.EventHandler(this.buttonAddModel_Click);
            // 
            // tableOptimizationMethods
            // 
            this.tableOptimizationMethods.AllowUserToAddRows = false;
            this.tableOptimizationMethods.AllowUserToDeleteRows = false;
            this.tableOptimizationMethods.AllowUserToResizeRows = false;
            this.tableOptimizationMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOptimizationMethods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMethod,
            this.nameMethod,
            this.activeMethod});
            this.tableOptimizationMethods.Location = new System.Drawing.Point(524, 281);
            this.tableOptimizationMethods.Name = "tableOptimizationMethods";
            this.tableOptimizationMethods.RowHeadersWidth = 51;
            this.tableOptimizationMethods.RowTemplate.Height = 24;
            this.tableOptimizationMethods.Size = new System.Drawing.Size(477, 150);
            this.tableOptimizationMethods.TabIndex = 5;
            this.tableOptimizationMethods.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableOptimizationMethods_CellMouseUp);
            // 
            // idMethod
            // 
            this.idMethod.HeaderText = "Номер";
            this.idMethod.MinimumWidth = 6;
            this.idMethod.Name = "idMethod";
            this.idMethod.Width = 75;
            // 
            // nameMethod
            // 
            this.nameMethod.HeaderText = "Название метода";
            this.nameMethod.MinimumWidth = 6;
            this.nameMethod.Name = "nameMethod";
            this.nameMethod.Width = 110;
            // 
            // activeMethod
            // 
            this.activeMethod.HeaderText = "Активен";
            this.activeMethod.MinimumWidth = 6;
            this.activeMethod.Name = "activeMethod";
            this.activeMethod.Width = 110;
            // 
            // tableUsers
            // 
            this.tableUsers.AllowUserToAddRows = false;
            this.tableUsers.AllowUserToDeleteRows = false;
            this.tableUsers.AllowUserToResizeRows = false;
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.nameUser,
            this.passwordUser});
            this.tableUsers.Location = new System.Drawing.Point(19, 281);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.RowHeadersWidth = 51;
            this.tableUsers.RowTemplate.Height = 24;
            this.tableUsers.Size = new System.Drawing.Size(484, 150);
            this.tableUsers.TabIndex = 4;
            this.tableUsers.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableUsers_CellMouseUp);
            // 
            // idUser
            // 
            this.idUser.HeaderText = "Номер";
            this.idUser.MinimumWidth = 6;
            this.idUser.Name = "idUser";
            this.idUser.Width = 75;
            // 
            // nameUser
            // 
            this.nameUser.HeaderText = "Имя пользователя";
            this.nameUser.MinimumWidth = 6;
            this.nameUser.Name = "nameUser";
            this.nameUser.Width = 110;
            // 
            // passwordUser
            // 
            this.passwordUser.HeaderText = "Пароль";
            this.passwordUser.MinimumWidth = 6;
            this.passwordUser.Name = "passwordUser";
            this.passwordUser.Width = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Таблица методов оптимизации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Таблица пользователей";
            // 
            // tableOptimizationModels
            // 
            this.tableOptimizationModels.AllowUserToAddRows = false;
            this.tableOptimizationModels.AllowUserToDeleteRows = false;
            this.tableOptimizationModels.AllowUserToResizeRows = false;
            this.tableOptimizationModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOptimizationModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModel,
            this.nameModel,
            this.textMethod,
            this.targetfunction,
            this.modeloptimozation,
            this.secondrestruction,
            this.sinssecondrestruction,
            this.maxminsecondrestr,
            this.flagminmaxextremumserch,
            this.lbvariableone,
            this.rbvariableone,
            this.lbvariabletwo,
            this.rbvariabletwo,
            this.accuracy});
            this.tableOptimizationModels.Location = new System.Drawing.Point(19, 48);
            this.tableOptimizationModels.Name = "tableOptimizationModels";
            this.tableOptimizationModels.RowHeadersWidth = 51;
            this.tableOptimizationModels.RowTemplate.Height = 24;
            this.tableOptimizationModels.Size = new System.Drawing.Size(804, 210);
            this.tableOptimizationModels.TabIndex = 1;
            this.tableOptimizationModels.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableOptimizationModels_CellMouseUp);
            // 
            // idModel
            // 
            this.idModel.HeaderText = "Номер";
            this.idModel.MinimumWidth = 6;
            this.idModel.Name = "idModel";
            this.idModel.Width = 65;
            // 
            // nameModel
            // 
            this.nameModel.HeaderText = "Название";
            this.nameModel.MinimumWidth = 6;
            this.nameModel.Name = "nameModel";
            this.nameModel.Width = 125;
            // 
            // textMethod
            // 
            this.textMethod.HeaderText = "Описание задачи оптимизации";
            this.textMethod.MinimumWidth = 6;
            this.textMethod.Name = "textMethod";
            this.textMethod.Width = 175;
            // 
            // targetfunction
            // 
            this.targetfunction.HeaderText = "Целевая функция";
            this.targetfunction.MinimumWidth = 6;
            this.targetfunction.Name = "targetfunction";
            this.targetfunction.Width = 75;
            // 
            // modeloptimozation
            // 
            this.modeloptimozation.HeaderText = "Оптимизационная функция";
            this.modeloptimozation.MinimumWidth = 6;
            this.modeloptimozation.Name = "modeloptimozation";
            this.modeloptimozation.Width = 150;
            // 
            // secondrestruction
            // 
            this.secondrestruction.HeaderText = "Формула ограничения второго уровня";
            this.secondrestruction.MinimumWidth = 6;
            this.secondrestruction.Name = "secondrestruction";
            this.secondrestruction.Width = 125;
            // 
            // sinssecondrestruction
            // 
            this.sinssecondrestruction.HeaderText = "Знак ограничения второго уровня";
            this.sinssecondrestruction.MinimumWidth = 6;
            this.sinssecondrestruction.Name = "sinssecondrestruction";
            this.sinssecondrestruction.Width = 75;
            // 
            // maxminsecondrestr
            // 
            this.maxminsecondrestr.HeaderText = "Граничное значения ограничения второго уровня";
            this.maxminsecondrestr.MinimumWidth = 6;
            this.maxminsecondrestr.Name = "maxminsecondrestr";
            this.maxminsecondrestr.Width = 75;
            // 
            // flagminmaxextremumserch
            // 
            this.flagminmaxextremumserch.HeaderText = "Поиск максимума";
            this.flagminmaxextremumserch.MinimumWidth = 6;
            this.flagminmaxextremumserch.Name = "flagminmaxextremumserch";
            this.flagminmaxextremumserch.Width = 75;
            // 
            // lbvariableone
            // 
            this.lbvariableone.HeaderText = "Левая граница 1-го параметра";
            this.lbvariableone.MinimumWidth = 6;
            this.lbvariableone.Name = "lbvariableone";
            this.lbvariableone.Width = 75;
            // 
            // rbvariableone
            // 
            this.rbvariableone.HeaderText = "Правая граница 1-го параметра";
            this.rbvariableone.MinimumWidth = 6;
            this.rbvariableone.Name = "rbvariableone";
            this.rbvariableone.Width = 75;
            // 
            // lbvariabletwo
            // 
            this.lbvariabletwo.HeaderText = "Левая граница 2-го параметра";
            this.lbvariabletwo.MinimumWidth = 6;
            this.lbvariabletwo.Name = "lbvariabletwo";
            this.lbvariabletwo.Width = 75;
            // 
            // rbvariabletwo
            // 
            this.rbvariabletwo.HeaderText = "Правая граница 2-го параметра";
            this.rbvariabletwo.MinimumWidth = 6;
            this.rbvariabletwo.Name = "rbvariabletwo";
            this.rbvariabletwo.Width = 75;
            // 
            // accuracy
            // 
            this.accuracy.HeaderText = "Точность";
            this.accuracy.MinimumWidth = 6;
            this.accuracy.Name = "accuracy";
            this.accuracy.Width = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Таблица задач оптимизации";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 546);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAdministration);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.authorizationGroupBox);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.authorizationGroupBox.ResumeLayout(false);
            this.authorizationGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxAdministration.ResumeLayout(false);
            this.groupBoxAdministration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOptimizationMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOptimizationModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox authorizationGroupBox;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.GroupBox groupBoxAdministration;
        private System.Windows.Forms.DataGridView tableOptimizationMethods;
        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tableOptimizationModels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn textMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetfunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloptimozation;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondrestruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinssecondrestruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxminsecondrestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagminmaxextremumserch;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbvariableone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rbvariableone;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbvariabletwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rbvariabletwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracy;
        private System.Windows.Forms.Button buttonAddModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteModel;
        private System.Windows.Forms.Button buttonUpdateModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDeleteMethod;
        private System.Windows.Forms.Button buttonUpdateMethod;
        private System.Windows.Forms.Button buttonAddMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordUser;
    }
}