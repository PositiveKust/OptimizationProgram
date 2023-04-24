
namespace _494KazantsevAM_Variant_7
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.общееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Graph = new System.Windows.Forms.ToolStripButton();
            this.comboBoxTask = new System.Windows.Forms.ComboBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelModelOptimization = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNameVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValueVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetTaskOptimizatopn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRestrictionsecondkind = new System.Windows.Forms.TextBox();
            this.textBoxBorderRestrictionsecondkind = new System.Windows.Forms.TextBox();
            this.comboBoxSign = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LeftBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMethod = new System.Windows.Forms.Label();
            this.comboBoxMethodSerch = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttondeletemodel = new System.Windows.Forms.Button();
            this.buttoncalculategraph = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееToolStripMenuItem,
            this.Graph});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // общееToolStripMenuItem
            // 
            this.общееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.добавитьЗаданиеToolStripMenuItem,
            this.авторизацияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.общееToolStripMenuItem.Name = "общееToolStripMenuItem";
            this.общееToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.общееToolStripMenuItem.Text = "Общее";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // добавитьЗаданиеToolStripMenuItem
            // 
            this.добавитьЗаданиеToolStripMenuItem.Name = "добавитьЗаданиеToolStripMenuItem";
            this.добавитьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.добавитьЗаданиеToolStripMenuItem.Text = "Добавить задание";
            this.добавитьЗаданиеToolStripMenuItem.Visible = false;
            this.добавитьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаданиеToolStripMenuItem_Click);
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            this.авторизацияToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // Graph
            // 
            this.Graph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Graph.Image = ((System.Drawing.Image)(resources.GetObject("Graph.Image")));
            this.Graph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(72, 24);
            this.Graph.Text = "Графики";
            this.Graph.Click += new System.EventHandler(this.Graph_Click);
            // 
            // comboBoxTask
            // 
            this.comboBoxTask.FormattingEnabled = true;
            this.comboBoxTask.Location = new System.Drawing.Point(205, 30);
            this.comboBoxTask.Name = "comboBoxTask";
            this.comboBoxTask.Size = new System.Drawing.Size(282, 24);
            this.comboBoxTask.TabIndex = 21;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(12, 34);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(137, 17);
            this.labelTask.TabIndex = 22;
            this.labelTask.Text = "Выберете задание:";
            // 
            // labelModelOptimization
            // 
            this.labelModelOptimization.AutoSize = true;
            this.labelModelOptimization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModelOptimization.Location = new System.Drawing.Point(10, 72);
            this.labelModelOptimization.Name = "labelModelOptimization";
            this.labelModelOptimization.Size = new System.Drawing.Size(200, 25);
            this.labelModelOptimization.TabIndex = 23;
            this.labelModelOptimization.Text = "Задание не выбрано";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Модель оптимизации:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameVariable,
            this.ColumnValueVariable});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(15, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(317, 191);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnNameVariable
            // 
            this.ColumnNameVariable.HeaderText = "Множитель";
            this.ColumnNameVariable.MinimumWidth = 6;
            this.ColumnNameVariable.Name = "ColumnNameVariable";
            this.ColumnNameVariable.ReadOnly = true;
            this.ColumnNameVariable.Width = 75;
            // 
            // ColumnValueVariable
            // 
            this.ColumnValueVariable.HeaderText = "Значение множителя";
            this.ColumnValueVariable.MinimumWidth = 6;
            this.ColumnValueVariable.Name = "ColumnValueVariable";
            this.ColumnValueVariable.Width = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Постоянные множители:";
            // 
            // buttonSetTaskOptimizatopn
            // 
            this.buttonSetTaskOptimizatopn.Location = new System.Drawing.Point(493, 27);
            this.buttonSetTaskOptimizatopn.Name = "buttonSetTaskOptimizatopn";
            this.buttonSetTaskOptimizatopn.Size = new System.Drawing.Size(90, 28);
            this.buttonSetTaskOptimizatopn.TabIndex = 27;
            this.buttonSetTaskOptimizatopn.Text = "Выбрать";
            this.buttonSetTaskOptimizatopn.UseVisualStyleBackColor = true;
            this.buttonSetTaskOptimizatopn.Click += new System.EventHandler(this.buttonSetTaskOptimizatopn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(338, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(433, 191);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "Нет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Задача оптимизации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ограничение 1-го рода:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ограничение 2-го рода:";
            // 
            // textBoxRestrictionsecondkind
            // 
            this.textBoxRestrictionsecondkind.Location = new System.Drawing.Point(338, 362);
            this.textBoxRestrictionsecondkind.Name = "textBoxRestrictionsecondkind";
            this.textBoxRestrictionsecondkind.ReadOnly = true;
            this.textBoxRestrictionsecondkind.Size = new System.Drawing.Size(134, 22);
            this.textBoxRestrictionsecondkind.TabIndex = 32;
            this.textBoxRestrictionsecondkind.Text = "T1 - T2";
            // 
            // textBoxBorderRestrictionsecondkind
            // 
            this.textBoxBorderRestrictionsecondkind.Location = new System.Drawing.Point(532, 364);
            this.textBoxBorderRestrictionsecondkind.Name = "textBoxBorderRestrictionsecondkind";
            this.textBoxBorderRestrictionsecondkind.ReadOnly = true;
            this.textBoxBorderRestrictionsecondkind.Size = new System.Drawing.Size(57, 22);
            this.textBoxBorderRestrictionsecondkind.TabIndex = 34;
            // 
            // comboBoxSign
            // 
            this.comboBoxSign.Enabled = false;
            this.comboBoxSign.FormattingEnabled = true;
            this.comboBoxSign.Items.AddRange(new object[] {
            "≤",
            "=",
            "≥"});
            this.comboBoxSign.Location = new System.Drawing.Point(476, 362);
            this.comboBoxSign.Name = "comboBoxSign";
            this.comboBoxSign.Size = new System.Drawing.Size(50, 24);
            this.comboBoxSign.TabIndex = 33;
            this.comboBoxSign.Text = "≤";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftBoard,
            this.NameVariable,
            this.RightBoard});
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(15, 342);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(304, 133);
            this.dataGridView2.TabIndex = 35;
            // 
            // LeftBoard
            // 
            this.LeftBoard.HeaderText = "Левая граница";
            this.LeftBoard.MinimumWidth = 6;
            this.LeftBoard.Name = "LeftBoard";
            this.LeftBoard.ReadOnly = true;
            this.LeftBoard.Width = 55;
            // 
            // NameVariable
            // 
            this.NameVariable.HeaderText = "Параметр";
            this.NameVariable.MinimumWidth = 6;
            this.NameVariable.Name = "NameVariable";
            this.NameVariable.ReadOnly = true;
            this.NameVariable.Width = 65;
            // 
            // RightBoard
            // 
            this.RightBoard.HeaderText = "Правая граница";
            this.RightBoard.MinimumWidth = 6;
            this.RightBoard.Name = "RightBoard";
            this.RightBoard.ReadOnly = true;
            this.RightBoard.Width = 55;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(335, 427);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(107, 17);
            this.labelMethod.TabIndex = 36;
            this.labelMethod.Text = "Выбор метода:";
            // 
            // comboBoxMethodSerch
            // 
            this.comboBoxMethodSerch.Enabled = false;
            this.comboBoxMethodSerch.FormattingEnabled = true;
            this.comboBoxMethodSerch.Items.AddRange(new object[] {
            "Метод полного перебора с постоянным шагом",
            "Метод полного перебора с переменным шагом",
            "Комплекс-метод Бокса",
            "Генетический алгоритм"});
            this.comboBoxMethodSerch.Location = new System.Drawing.Point(338, 447);
            this.comboBoxMethodSerch.Name = "comboBoxMethodSerch";
            this.comboBoxMethodSerch.Size = new System.Drawing.Size(282, 24);
            this.comboBoxMethodSerch.TabIndex = 37;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(626, 427);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(145, 48);
            this.buttonCalculate.TabIndex = 38;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttondeletemodel
            // 
            this.buttondeletemodel.Enabled = false;
            this.buttondeletemodel.Location = new System.Drawing.Point(589, 28);
            this.buttondeletemodel.Name = "buttondeletemodel";
            this.buttondeletemodel.Size = new System.Drawing.Size(90, 28);
            this.buttondeletemodel.TabIndex = 39;
            this.buttondeletemodel.Text = "Удалить";
            this.buttondeletemodel.UseVisualStyleBackColor = true;
            this.buttondeletemodel.Visible = false;
            this.buttondeletemodel.Click += new System.EventHandler(this.buttondeletemodel_Click);
            // 
            // buttoncalculategraph
            // 
            this.buttoncalculategraph.Enabled = false;
            this.buttoncalculategraph.Location = new System.Drawing.Point(595, 342);
            this.buttoncalculategraph.Name = "buttoncalculategraph";
            this.buttoncalculategraph.Size = new System.Drawing.Size(176, 44);
            this.buttoncalculategraph.TabIndex = 40;
            this.buttoncalculategraph.Text = "Рассчитать графики";
            this.buttoncalculategraph.UseVisualStyleBackColor = true;
            this.buttoncalculategraph.Click += new System.EventHandler(this.buttoncalculategraph_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.buttoncalculategraph);
            this.Controls.Add(this.buttondeletemodel);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxMethodSerch);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxRestrictionsecondkind);
            this.Controls.Add(this.textBoxBorderRestrictionsecondkind);
            this.Controls.Add(this.comboBoxSign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSetTaskOptimizatopn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelModelOptimization);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.comboBoxTask);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem общееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelModelOptimization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetTaskOptimizatopn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRestrictionsecondkind;
        private System.Windows.Forms.TextBox textBoxBorderRestrictionsecondkind;
        private System.Windows.Forms.ComboBox comboBoxSign;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.ComboBox comboBoxMethodSerch;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValueVariable;
        private System.Windows.Forms.Button buttondeletemodel;
        private System.Windows.Forms.Button buttoncalculategraph;
        private System.Windows.Forms.ToolStripButton Graph;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
    }
}