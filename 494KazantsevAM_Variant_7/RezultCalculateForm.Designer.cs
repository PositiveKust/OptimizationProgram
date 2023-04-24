
namespace _494KazantsevAM_Variant_7
{
    partial class RezultCalculateForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.скрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dгToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dграфикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewGraphValue = new System.Windows.Forms.DataGridView();
            this.VariableOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winChartViewer1 = new ChartDirector.WinChartViewer();
            this.dtablerezultmethod = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сохранитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraphValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtablerezultmethod)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скрытьToolStripMenuItem,
            this.таблицаToolStripMenuItem,
            this.dгToolStripMenuItem,
            this.dграфикToolStripMenuItem,
            this.сохранитьОтчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // скрытьToolStripMenuItem
            // 
            this.скрытьToolStripMenuItem.Name = "скрытьToolStripMenuItem";
            this.скрытьToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.скрытьToolStripMenuItem.Text = "Скрыть";
            this.скрытьToolStripMenuItem.Click += new System.EventHandler(this.скрытьToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click);
            // 
            // dгToolStripMenuItem
            // 
            this.dгToolStripMenuItem.Name = "dгToolStripMenuItem";
            this.dгToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.dгToolStripMenuItem.Text = "2D-график";
            this.dгToolStripMenuItem.Click += new System.EventHandler(this.dгToolStripMenuItem_Click);
            // 
            // dграфикToolStripMenuItem
            // 
            this.dграфикToolStripMenuItem.Name = "dграфикToolStripMenuItem";
            this.dграфикToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.dграфикToolStripMenuItem.Text = "3D-график";
            this.dграфикToolStripMenuItem.Click += new System.EventHandler(this.dграфикToolStripMenuItem_Click);
            // 
            // dataGridViewGraphValue
            // 
            this.dataGridViewGraphValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGraphValue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VariableOne,
            this.VariableTwo,
            this.Rezult});
            this.dataGridViewGraphValue.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewGraphValue.Name = "dataGridViewGraphValue";
            this.dataGridViewGraphValue.ReadOnly = true;
            this.dataGridViewGraphValue.RowHeadersWidth = 51;
            this.dataGridViewGraphValue.RowTemplate.Height = 24;
            this.dataGridViewGraphValue.Size = new System.Drawing.Size(482, 425);
            this.dataGridViewGraphValue.TabIndex = 1;
            this.dataGridViewGraphValue.Visible = false;
            // 
            // VariableOne
            // 
            this.VariableOne.HeaderText = "Column1";
            this.VariableOne.MinimumWidth = 6;
            this.VariableOne.Name = "VariableOne";
            this.VariableOne.ReadOnly = true;
            this.VariableOne.Width = 125;
            // 
            // VariableTwo
            // 
            this.VariableTwo.HeaderText = "Column1";
            this.VariableTwo.MinimumWidth = 6;
            this.VariableTwo.Name = "VariableTwo";
            this.VariableTwo.ReadOnly = true;
            this.VariableTwo.Width = 125;
            // 
            // Rezult
            // 
            this.Rezult.HeaderText = "Значение целевой функции";
            this.Rezult.MinimumWidth = 6;
            this.Rezult.Name = "Rezult";
            this.Rezult.ReadOnly = true;
            this.Rezult.Width = 200;
            // 
            // winChartViewer1
            // 
            this.winChartViewer1.Location = new System.Drawing.Point(0, 28);
            this.winChartViewer1.Name = "winChartViewer1";
            this.winChartViewer1.Size = new System.Drawing.Size(505, 317);
            this.winChartViewer1.TabIndex = 2;
            this.winChartViewer1.TabStop = false;
            // 
            // dtablerezultmethod
            // 
            this.dtablerezultmethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtablerezultmethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z});
            this.dtablerezultmethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtablerezultmethod.Location = new System.Drawing.Point(0, 28);
            this.dtablerezultmethod.Name = "dtablerezultmethod";
            this.dtablerezultmethod.RowHeadersWidth = 51;
            this.dtablerezultmethod.RowTemplate.Height = 24;
            this.dtablerezultmethod.Size = new System.Drawing.Size(505, 425);
            this.dtablerezultmethod.TabIndex = 3;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 125;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.MinimumWidth = 6;
            this.Z.Name = "Z";
            this.Z.Width = 125;
            // 
            // сохранитьОтчетToolStripMenuItem
            // 
            this.сохранитьОтчетToolStripMenuItem.Enabled = false;
            this.сохранитьОтчетToolStripMenuItem.Name = "сохранитьОтчетToolStripMenuItem";
            this.сохранитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.сохранитьОтчетToolStripMenuItem.Text = "Сохранить отчет";
            this.сохранитьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОтчетToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = ".xlsx | .xlsx";
            // 
            // RezultCalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 453);
            this.ControlBox = false;
            this.Controls.Add(this.dtablerezultmethod);
            this.Controls.Add(this.winChartViewer1);
            this.Controls.Add(this.dataGridViewGraphValue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RezultCalculateForm";
            this.Text = "Таблица";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraphValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtablerezultmethod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dгToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dграфикToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewGraphValue;
        private System.Windows.Forms.ToolStripMenuItem скрытьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezult;
        private ChartDirector.WinChartViewer winChartViewer1;
        private System.Windows.Forms.DataGridView dtablerezultmethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОтчетToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}