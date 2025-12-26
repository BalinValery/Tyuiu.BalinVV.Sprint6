namespace Tyuiu.BalinVV.Sprint6.Task7.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_BVV = new System.Windows.Forms.Panel();
            this.buttonHelp_BVV = new System.Windows.Forms.Button();
            this.buttonSaveFile_BVV = new System.Windows.Forms.Button();
            this.buttonDone_BVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_BVV = new System.Windows.Forms.Button();
            this.panelCondition_BVV = new System.Windows.Forms.Panel();
            this.groupBoxCondition_BVV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelInPut_BVV = new System.Windows.Forms.Panel();
            this.groupBoxInPut_BVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_BVV = new System.Windows.Forms.DataGridView();
            this.splitterInPut_BVV = new System.Windows.Forms.Splitter();
            this.panelOutPut_BVV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_BVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_BVV = new System.Windows.Forms.DataGridView();
            this.splitterOutPut_BVV = new System.Windows.Forms.Splitter();
            this.toolTipButton_BVV = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_BVV = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTask7_BVV = new System.Windows.Forms.OpenFileDialog();
            this.panelButtons_BVV.SuspendLayout();
            this.panelCondition_BVV.SuspendLayout();
            this.groupBoxCondition_BVV.SuspendLayout();
            this.panelInPut_BVV.SuspendLayout();
            this.groupBoxInPut_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_BVV)).BeginInit();
            this.panelOutPut_BVV.SuspendLayout();
            this.groupBoxOutPut_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_BVV
            // 
            this.panelButtons_BVV.BackColor = System.Drawing.Color.White;
            this.panelButtons_BVV.Controls.Add(this.buttonHelp_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonSaveFile_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonDone_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonOpenFile_BVV);
            this.panelButtons_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BVV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BVV.Name = "panelButtons_BVV";
            this.panelButtons_BVV.Size = new System.Drawing.Size(1061, 94);
            this.panelButtons_BVV.TabIndex = 4;
            // 
            // buttonHelp_BVV
            // 
            this.buttonHelp_BVV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BVV.Image")));
            this.buttonHelp_BVV.Location = new System.Drawing.Point(965, 12);
            this.buttonHelp_BVV.Name = "buttonHelp_BVV";
            this.buttonHelp_BVV.Size = new System.Drawing.Size(84, 76);
            this.buttonHelp_BVV.TabIndex = 3;
            this.toolTipButton_BVV.SetToolTip(this.buttonHelp_BVV, " О программе");
            this.buttonHelp_BVV.UseVisualStyleBackColor = true;
            this.buttonHelp_BVV.Click += new System.EventHandler(this.buttonHelp_BVV_Click);
            this.buttonHelp_BVV.MouseEnter += new System.EventHandler(this.buttonHelp_BVV_MouseEnter);
            // 
            // buttonSaveFile_BVV
            // 
            this.buttonSaveFile_BVV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_BVV.Enabled = false;
            this.buttonSaveFile_BVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_BVV.Image")));
            this.buttonSaveFile_BVV.Location = new System.Drawing.Point(212, 12);
            this.buttonSaveFile_BVV.Name = "buttonSaveFile_BVV";
            this.buttonSaveFile_BVV.Size = new System.Drawing.Size(83, 76);
            this.buttonSaveFile_BVV.TabIndex = 2;
            this.toolTipButton_BVV.SetToolTip(this.buttonSaveFile_BVV, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_BVV.UseVisualStyleBackColor = true;
            this.buttonSaveFile_BVV.Click += new System.EventHandler(this.buttonSaveFile_BVV_Click);
            this.buttonSaveFile_BVV.MouseEnter += new System.EventHandler(this.buttonSaveFile_BVV_MouseEnter);
            // 
            // buttonDone_BVV
            // 
            this.buttonDone_BVV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BVV.Enabled = false;
            this.buttonDone_BVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BVV.Image")));
            this.buttonDone_BVV.Location = new System.Drawing.Point(110, 12);
            this.buttonDone_BVV.Name = "buttonDone_BVV";
            this.buttonDone_BVV.Size = new System.Drawing.Size(86, 76);
            this.buttonDone_BVV.TabIndex = 1;
            this.toolTipButton_BVV.SetToolTip(this.buttonDone_BVV, "Выполнить обработку данных");
            this.buttonDone_BVV.UseVisualStyleBackColor = true;
            this.buttonDone_BVV.Click += new System.EventHandler(this.buttonDone_BVV_Click);
            this.buttonDone_BVV.MouseEnter += new System.EventHandler(this.buttonDone_BVV_MouseEnter);
            // 
            // buttonOpenFile_BVV
            // 
            this.buttonOpenFile_BVV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BVV.Image")));
            this.buttonOpenFile_BVV.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_BVV.Name = "buttonOpenFile_BVV";
            this.buttonOpenFile_BVV.Size = new System.Drawing.Size(83, 76);
            this.buttonOpenFile_BVV.TabIndex = 0;
            this.toolTipButton_BVV.SetToolTip(this.buttonOpenFile_BVV, "Открыть файл для обработки данных в формат СSV\r\n");
            this.buttonOpenFile_BVV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BVV.Click += new System.EventHandler(this.buttonOpenFile_BVV_Click);
            this.buttonOpenFile_BVV.MouseEnter += new System.EventHandler(this.buttonOpenFile_BVV_MouseEnter);
            // 
            // panelCondition_BVV
            // 
            this.panelCondition_BVV.BackColor = System.Drawing.Color.White;
            this.panelCondition_BVV.Controls.Add(this.groupBoxCondition_BVV);
            this.panelCondition_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_BVV.Location = new System.Drawing.Point(0, 94);
            this.panelCondition_BVV.Name = "panelCondition_BVV";
            this.panelCondition_BVV.Size = new System.Drawing.Size(1061, 78);
            this.panelCondition_BVV.TabIndex = 5;
            // 
            // groupBoxCondition_BVV
            // 
            this.groupBoxCondition_BVV.Controls.Add(this.textBox1);
            this.groupBoxCondition_BVV.Location = new System.Drawing.Point(3, 7);
            this.groupBoxCondition_BVV.Name = "groupBoxCondition_BVV";
            this.groupBoxCondition_BVV.Size = new System.Drawing.Size(1055, 89);
            this.groupBoxCondition_BVV.TabIndex = 0;
            this.groupBoxCondition_BVV.TabStop = false;
            this.groupBoxCondition_BVV.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1055, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInPut_BVV
            // 
            this.panelInPut_BVV.BackColor = System.Drawing.Color.White;
            this.panelInPut_BVV.Controls.Add(this.groupBoxInPut_BVV);
            this.panelInPut_BVV.Controls.Add(this.splitterInPut_BVV);
            this.panelInPut_BVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_BVV.Location = new System.Drawing.Point(0, 172);
            this.panelInPut_BVV.Name = "panelInPut_BVV";
            this.panelInPut_BVV.Size = new System.Drawing.Size(522, 449);
            this.panelInPut_BVV.TabIndex = 6;
            // 
            // groupBoxInPut_BVV
            // 
            this.groupBoxInPut_BVV.Controls.Add(this.dataGridViewInPut_BVV);
            this.groupBoxInPut_BVV.Location = new System.Drawing.Point(3, 6);
            this.groupBoxInPut_BVV.Name = "groupBoxInPut_BVV";
            this.groupBoxInPut_BVV.Size = new System.Drawing.Size(519, 440);
            this.groupBoxInPut_BVV.TabIndex = 1;
            this.groupBoxInPut_BVV.TabStop = false;
            this.groupBoxInPut_BVV.Text = "Ввод:";
            // 
            // dataGridViewInPut_BVV
            // 
            this.dataGridViewInPut_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_BVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInPut_BVV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_BVV.Name = "dataGridViewInPut_BVV";
            this.dataGridViewInPut_BVV.RowHeadersWidth = 51;
            this.dataGridViewInPut_BVV.RowTemplate.Height = 24;
            this.dataGridViewInPut_BVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInPut_BVV.Size = new System.Drawing.Size(513, 419);
            this.dataGridViewInPut_BVV.TabIndex = 0;
            // 
            // splitterInPut_BVV
            // 
            this.splitterInPut_BVV.Location = new System.Drawing.Point(0, 0);
            this.splitterInPut_BVV.Name = "splitterInPut_BVV";
            this.splitterInPut_BVV.Size = new System.Drawing.Size(3, 449);
            this.splitterInPut_BVV.TabIndex = 0;
            this.splitterInPut_BVV.TabStop = false;
            // 
            // panelOutPut_BVV
            // 
            this.panelOutPut_BVV.BackColor = System.Drawing.Color.White;
            this.panelOutPut_BVV.Controls.Add(this.groupBoxOutPut_BVV);
            this.panelOutPut_BVV.Controls.Add(this.splitterOutPut_BVV);
            this.panelOutPut_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_BVV.Location = new System.Drawing.Point(522, 172);
            this.panelOutPut_BVV.Name = "panelOutPut_BVV";
            this.panelOutPut_BVV.Size = new System.Drawing.Size(539, 449);
            this.panelOutPut_BVV.TabIndex = 7;
            // 
            // groupBoxOutPut_BVV
            // 
            this.groupBoxOutPut_BVV.Controls.Add(this.dataGridViewOutPut_BVV);
            this.groupBoxOutPut_BVV.Location = new System.Drawing.Point(6, 6);
            this.groupBoxOutPut_BVV.Name = "groupBoxOutPut_BVV";
            this.groupBoxOutPut_BVV.Size = new System.Drawing.Size(530, 440);
            this.groupBoxOutPut_BVV.TabIndex = 1;
            this.groupBoxOutPut_BVV.TabStop = false;
            this.groupBoxOutPut_BVV.Text = "Вывод:";
            // 
            // dataGridViewOutPut_BVV
            // 
            this.dataGridViewOutPut_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_BVV.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOutPut_BVV.Location = new System.Drawing.Point(0, 18);
            this.dataGridViewOutPut_BVV.Name = "dataGridViewOutPut_BVV";
            this.dataGridViewOutPut_BVV.RowHeadersWidth = 51;
            this.dataGridViewOutPut_BVV.RowTemplate.Height = 24;
            this.dataGridViewOutPut_BVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_BVV.Size = new System.Drawing.Size(527, 419);
            this.dataGridViewOutPut_BVV.TabIndex = 0;
            // 
            // splitterOutPut_BVV
            // 
            this.splitterOutPut_BVV.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_BVV.Name = "splitterOutPut_BVV";
            this.splitterOutPut_BVV.Size = new System.Drawing.Size(3, 449);
            this.splitterOutPut_BVV.TabIndex = 0;
            this.splitterOutPut_BVV.TabStop = false;
            // 
            // toolTipButton_BVV
            // 
            this.toolTipButton_BVV.IsBalloon = true;
            this.toolTipButton_BVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialogTask7_BVV
            // 
            this.openFileDialogTask7_BVV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 621);
            this.Controls.Add(this.panelOutPut_BVV);
            this.Controls.Add(this.panelInPut_BVV);
            this.Controls.Add(this.panelCondition_BVV);
            this.Controls.Add(this.panelButtons_BVV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сприант 7 | Таск 7 | Вариант 7 | Балин В.В.";
            this.panelButtons_BVV.ResumeLayout(false);
            this.panelCondition_BVV.ResumeLayout(false);
            this.groupBoxCondition_BVV.ResumeLayout(false);
            this.groupBoxCondition_BVV.PerformLayout();
            this.panelInPut_BVV.ResumeLayout(false);
            this.groupBoxInPut_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_BVV)).EndInit();
            this.panelOutPut_BVV.ResumeLayout(false);
            this.groupBoxOutPut_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BVV;
        private System.Windows.Forms.Panel panelCondition_BVV;
        private System.Windows.Forms.Panel panelInPut_BVV;
        private System.Windows.Forms.Panel panelOutPut_BVV;
        private System.Windows.Forms.Button buttonOpenFile_BVV;
        private System.Windows.Forms.Button buttonSaveFile_BVV;
        private System.Windows.Forms.Button buttonDone_BVV;
        private System.Windows.Forms.Button buttonHelp_BVV;
        private System.Windows.Forms.GroupBox groupBoxCondition_BVV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_BVV;
        private System.Windows.Forms.DataGridView dataGridViewInPut_BVV;
        private System.Windows.Forms.Splitter splitterInPut_BVV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BVV;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_BVV;
        private System.Windows.Forms.Splitter splitterOutPut_BVV;
        private System.Windows.Forms.ToolTip toolTipButton_BVV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_BVV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask7_BVV;
    }
}