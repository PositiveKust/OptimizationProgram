
using System.Windows.Forms;

namespace _494KazantsevAM_Variant_7
{
    partial class AddNewObjectOptimization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkedChangeVariable = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelcheckedChangeVariable = new System.Windows.Forms.Label();
            this.labelValueConstVariable = new System.Windows.Forms.Label();
            this.textBoxObjectOptimization = new System.Windows.Forms.TextBox();
            this.labelSetObjectOptimization = new System.Windows.Forms.Label();
            this.dataGridLeftandRightBoardVariable = new System.Windows.Forms.DataGridView();
            this.LeftBoardVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightBoardVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRestrictionsecondkind = new System.Windows.Forms.TextBox();
            this.comboBoxSign = new System.Windows.Forms.ComboBox();
            this.textBoxBorderRestrictionsecondkind = new System.Windows.Forms.TextBox();
            this.labelAlinformation = new System.Windows.Forms.Label();
            this.panelseObjectoptimization = new System.Windows.Forms.Panel();
            this.textBoxAccuracy = new System.Windows.Forms.TextBox();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.comboBoxmimmax = new System.Windows.Forms.ComboBox();
            this.textBoxNameOptimization = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTargetFunction = new System.Windows.Forms.TextBox();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeftandRightBoardVariable)).BeginInit();
            this.panelseObjectoptimization.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(587, 385);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(152, 50);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 385);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 50);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // checkedChangeVariable
            // 
            this.checkedChangeVariable.FormattingEnabled = true;
            this.checkedChangeVariable.Location = new System.Drawing.Point(13, 136);
            this.checkedChangeVariable.Name = "checkedChangeVariable";
            this.checkedChangeVariable.Size = new System.Drawing.Size(254, 191);
            this.checkedChangeVariable.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // labelcheckedChangeVariable
            // 
            this.labelcheckedChangeVariable.AutoSize = true;
            this.labelcheckedChangeVariable.Location = new System.Drawing.Point(10, 106);
            this.labelcheckedChangeVariable.Name = "labelcheckedChangeVariable";
            this.labelcheckedChangeVariable.Size = new System.Drawing.Size(216, 17);
            this.labelcheckedChangeVariable.TabIndex = 4;
            this.labelcheckedChangeVariable.Text = "Введите полный текст задания";
            // 
            // labelValueConstVariable
            // 
            this.labelValueConstVariable.AutoSize = true;
            this.labelValueConstVariable.Location = new System.Drawing.Point(383, 106);
            this.labelValueConstVariable.Name = "labelValueConstVariable";
            this.labelValueConstVariable.Size = new System.Drawing.Size(325, 17);
            this.labelValueConstVariable.TabIndex = 5;
            this.labelValueConstVariable.Text = "Введите значения неизменяеммых переменных";
            // 
            // textBoxObjectOptimization
            // 
            this.textBoxObjectOptimization.Location = new System.Drawing.Point(316, 61);
            this.textBoxObjectOptimization.Name = "textBoxObjectOptimization";
            this.textBoxObjectOptimization.Size = new System.Drawing.Size(375, 22);
            this.textBoxObjectOptimization.TabIndex = 7;
            // 
            // labelSetObjectOptimization
            // 
            this.labelSetObjectOptimization.AutoSize = true;
            this.labelSetObjectOptimization.Location = new System.Drawing.Point(313, 41);
            this.labelSetObjectOptimization.Name = "labelSetObjectOptimization";
            this.labelSetObjectOptimization.Size = new System.Drawing.Size(238, 17);
            this.labelSetObjectOptimization.TabIndex = 8;
            this.labelSetObjectOptimization.Text = "Задача поиска в целевой функции";
            // 
            // dataGridLeftandRightBoardVariable
            // 
            this.dataGridLeftandRightBoardVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeftandRightBoardVariable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftBoardVariable,
            this.dataGridViewTextBoxColumn1,
            this.RightBoardVariable});
            this.dataGridLeftandRightBoardVariable.Location = new System.Drawing.Point(13, 136);
            this.dataGridLeftandRightBoardVariable.Name = "dataGridLeftandRightBoardVariable";
            this.dataGridLeftandRightBoardVariable.RowHeadersWidth = 51;
            this.dataGridLeftandRightBoardVariable.RowTemplate.Height = 24;
            this.dataGridLeftandRightBoardVariable.Size = new System.Drawing.Size(357, 223);
            this.dataGridLeftandRightBoardVariable.TabIndex = 10;
            // 
            // LeftBoardVariable
            // 
            this.LeftBoardVariable.HeaderText = "Левая граница переменной";
            this.LeftBoardVariable.MinimumWidth = 6;
            this.LeftBoardVariable.Name = "LeftBoardVariable";
            this.LeftBoardVariable.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя переменной";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // RightBoardVariable
            // 
            this.RightBoardVariable.HeaderText = "Правая граница переменной";
            this.RightBoardVariable.MinimumWidth = 6;
            this.RightBoardVariable.Name = "RightBoardVariable";
            this.RightBoardVariable.Width = 75;
            // 
            // textBoxRestrictionsecondkind
            // 
            this.textBoxRestrictionsecondkind.Location = new System.Drawing.Point(386, 126);
            this.textBoxRestrictionsecondkind.Name = "textBoxRestrictionsecondkind";
            this.textBoxRestrictionsecondkind.Size = new System.Drawing.Size(165, 22);
            this.textBoxRestrictionsecondkind.TabIndex = 11;
            this.textBoxRestrictionsecondkind.Text = "0,5 * T1 + T2";
            // 
            // comboBoxSign
            // 
            this.comboBoxSign.FormattingEnabled = true;
            this.comboBoxSign.Items.AddRange(new object[] {
            "≤",
            "=",
            "≥"});
            this.comboBoxSign.Location = new System.Drawing.Point(557, 126);
            this.comboBoxSign.Name = "comboBoxSign";
            this.comboBoxSign.Size = new System.Drawing.Size(50, 24);
            this.comboBoxSign.TabIndex = 13;
            // 
            // textBoxBorderRestrictionsecondkind
            // 
            this.textBoxBorderRestrictionsecondkind.Location = new System.Drawing.Point(613, 128);
            this.textBoxBorderRestrictionsecondkind.Name = "textBoxBorderRestrictionsecondkind";
            this.textBoxBorderRestrictionsecondkind.Size = new System.Drawing.Size(78, 22);
            this.textBoxBorderRestrictionsecondkind.TabIndex = 14;
            // 
            // labelAlinformation
            // 
            this.labelAlinformation.AutoSize = true;
            this.labelAlinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlinformation.Location = new System.Drawing.Point(214, 0);
            this.labelAlinformation.Name = "labelAlinformation";
            this.labelAlinformation.Size = new System.Drawing.Size(337, 25);
            this.labelAlinformation.TabIndex = 15;
            this.labelAlinformation.Text = "Сохранение задания в базу данных";
            // 
            // panelseObjectoptimization
            // 
            this.panelseObjectoptimization.Controls.Add(this.textBoxAccuracy);
            this.panelseObjectoptimization.Controls.Add(this.labelAccuracy);
            this.panelseObjectoptimization.Controls.Add(this.comboBoxmimmax);
            this.panelseObjectoptimization.Controls.Add(this.textBoxNameOptimization);
            this.panelseObjectoptimization.Controls.Add(this.richTextBox1);
            this.panelseObjectoptimization.Controls.Add(this.label1);
            this.panelseObjectoptimization.Controls.Add(this.textBoxTargetFunction);
            this.panelseObjectoptimization.Controls.Add(this.buttonNext);
            this.panelseObjectoptimization.Controls.Add(this.labelAlinformation);
            this.panelseObjectoptimization.Controls.Add(this.buttonBack);
            this.panelseObjectoptimization.Controls.Add(this.textBoxRestrictionsecondkind);
            this.panelseObjectoptimization.Controls.Add(this.checkedChangeVariable);
            this.panelseObjectoptimization.Controls.Add(this.textBoxBorderRestrictionsecondkind);
            this.panelseObjectoptimization.Controls.Add(this.labelcheckedChangeVariable);
            this.panelseObjectoptimization.Controls.Add(this.comboBoxSign);
            this.panelseObjectoptimization.Controls.Add(this.labelValueConstVariable);
            this.panelseObjectoptimization.Controls.Add(this.dataGridLeftandRightBoardVariable);
            this.panelseObjectoptimization.Controls.Add(this.textBoxObjectOptimization);
            this.panelseObjectoptimization.Controls.Add(this.labelSetObjectOptimization);
            this.panelseObjectoptimization.Location = new System.Drawing.Point(28, 31);
            this.panelseObjectoptimization.Name = "panelseObjectoptimization";
            this.panelseObjectoptimization.Size = new System.Drawing.Size(745, 457);
            this.panelseObjectoptimization.TabIndex = 16;
            // 
            // textBoxAccuracy
            // 
            this.textBoxAccuracy.Location = new System.Drawing.Point(575, 83);
            this.textBoxAccuracy.Name = "textBoxAccuracy";
            this.textBoxAccuracy.Size = new System.Drawing.Size(116, 22);
            this.textBoxAccuracy.TabIndex = 22;
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Location = new System.Drawing.Point(313, 86);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(137, 17);
            this.labelAccuracy.TabIndex = 21;
            this.labelAccuracy.Text = "Точность решения:";
            // 
            // comboBoxmimmax
            // 
            this.comboBoxmimmax.FormattingEnabled = true;
            this.comboBoxmimmax.Items.AddRange(new object[] {
            "минимума",
            "максимума"});
            this.comboBoxmimmax.Location = new System.Drawing.Point(575, 38);
            this.comboBoxmimmax.Name = "comboBoxmimmax";
            this.comboBoxmimmax.Size = new System.Drawing.Size(116, 24);
            this.comboBoxmimmax.TabIndex = 20;
            this.comboBoxmimmax.Text = "минимума";
            // 
            // textBoxNameOptimization
            // 
            this.textBoxNameOptimization.Location = new System.Drawing.Point(13, 61);
            this.textBoxNameOptimization.Name = "textBoxNameOptimization";
            this.textBoxNameOptimization.Size = new System.Drawing.Size(213, 22);
            this.textBoxNameOptimization.TabIndex = 19;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(725, 233);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите название задачи оптимизации";
            // 
            // textBoxTargetFunction
            // 
            this.textBoxTargetFunction.Location = new System.Drawing.Point(13, 61);
            this.textBoxTargetFunction.Name = "textBoxTargetFunction";
            this.textBoxTargetFunction.Size = new System.Drawing.Size(213, 22);
            this.textBoxTargetFunction.TabIndex = 16;
            this.textBoxTargetFunction.Text = "T = V * 8";
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // AddNewObjectOptimization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 504);
            this.Controls.Add(this.panelseObjectoptimization);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddNewObjectOptimization";
            this.Text = "Добавление нового объекта оптимизации";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeftandRightBoardVariable)).EndInit();
            this.panelseObjectoptimization.ResumeLayout(false);
            this.panelseObjectoptimization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckedListBox checkedChangeVariable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.Label labelcheckedChangeVariable;
        private System.Windows.Forms.Label labelValueConstVariable;
        private System.Windows.Forms.TextBox textBoxObjectOptimization;
        private System.Windows.Forms.Label labelSetObjectOptimization;
        private System.Windows.Forms.DataGridView dataGridLeftandRightBoardVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftBoardVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightBoardVariable;
        private System.Windows.Forms.TextBox textBoxRestrictionsecondkind;
        private System.Windows.Forms.ComboBox comboBoxSign;
        private System.Windows.Forms.TextBox textBoxBorderRestrictionsecondkind;
        private System.Windows.Forms.Label labelAlinformation;
        private System.Windows.Forms.Panel panelseObjectoptimization;
        private Label label1;
        private TextBox textBoxTargetFunction;
        private RichTextBox richTextBox1;
        private TextBox textBoxNameOptimization;
        private ComboBox comboBoxmimmax;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private TextBox textBoxAccuracy;
        private Label labelAccuracy;
    }
}

