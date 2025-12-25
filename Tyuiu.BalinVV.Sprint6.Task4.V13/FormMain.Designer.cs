namespace Tyuiu.BalinVV.Sprint6.Task4.V13
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            HelpButton_BVV = new Button();
            InputTextBoxStart_BVV = new TextBox();
            InputTextBoxStop_BVV = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SolveButton_BVV = new Button();
            SaveButton_BVV = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            ResultTextBox_BVV = new TextBox();
            ChartFunctionResult_BVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunctionResult_BVV).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(770, 174);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(831, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(639, 174);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, -2);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 2;
            label1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(842, -2);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 3;
            label2.Text = "Ввод данных";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 42);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F);
            textBox3.Location = new Point(24, 77);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(721, 96);
            textBox3.TabIndex = 5;
            textBox3.Text = "Произвести табулирование функции на заданном диапазоне.\r\n\r\nРезультат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V13.txt по нажатию кнопки.";
            // 
            // HelpButton_BVV
            // 
            HelpButton_BVV.AutoSize = true;
            HelpButton_BVV.BackColor = Color.FromArgb(192, 192, 255);
            HelpButton_BVV.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            HelpButton_BVV.Location = new Point(1410, 20);
            HelpButton_BVV.Name = "HelpButton_PKK";
            HelpButton_BVV.Size = new Size(51, 51);
            HelpButton_BVV.TabIndex = 6;
            HelpButton_BVV.Text = "?";
            HelpButton_BVV.UseVisualStyleBackColor = false;
            HelpButton_BVV.Click += HelpButton_BVV_Click;
            // 
            // InputTextBoxStart_BVV
            // 
            InputTextBoxStart_BVV.BackColor = Color.FromArgb(255, 255, 192);
            InputTextBoxStart_BVV.Font = new Font("Segoe UI", 12F);
            InputTextBoxStart_BVV.Location = new Point(842, 54);
            InputTextBoxStart_BVV.Name = "InputTextBoxStart_BVV";
            InputTextBoxStart_BVV.Size = new Size(125, 34);
            InputTextBoxStart_BVV.TabIndex = 7;
            // 
            // InputTextBoxStop_BVV
            // 
            InputTextBoxStop_BVV.BackColor = Color.FromArgb(255, 255, 192);
            InputTextBoxStop_BVV.Font = new Font("Segoe UI", 12F);
            InputTextBoxStop_BVV.Location = new Point(842, 139);
            InputTextBoxStop_BVV.Name = "InputTextBoxStop_BVV";
            InputTextBoxStop_BVV.Size = new Size(125, 34);
            InputTextBoxStop_BVV.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(842, 29);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 9;
            label3.Text = "Начало шага:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(842, 116);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 10;
            label4.Text = "Конец шага:";
            // 
            // SolveButton_BVV
            // 
            SolveButton_BVV.BackColor = Color.FromArgb(192, 255, 192);
            SolveButton_BVV.Font = new Font("Segoe UI", 13F);
            SolveButton_BVV.Location = new Point(1082, 21);
            SolveButton_BVV.Name = "SolveButton_BVV";
            SolveButton_BVV.Size = new Size(137, 67);
            SolveButton_BVV.TabIndex = 11;
            SolveButton_BVV.Text = "Запустить";
            SolveButton_BVV.UseVisualStyleBackColor = false;
            SolveButton_BVV.Click += SolveButton_BVV_Click;
            // 
            // SaveButton_BVV
            // 
            SaveButton_BVV.BackColor = Color.FromArgb(128, 128, 255);
            SaveButton_BVV.Font = new Font("Segoe UI", 13F);
            SaveButton_BVV.Location = new Point(1082, 106);
            SaveButton_BVV.Name = "SaveButton_BVV";
            SaveButton_BVV.Size = new Size(137, 67);
            SaveButton_BVV.TabIndex = 12;
            SaveButton_BVV.Text = "Сохранить";
            SaveButton_BVV.UseVisualStyleBackColor = false;
            SaveButton_BVV.Click += SaveButton_BVV_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(12, 212);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(258, 315);
            textBox4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(24, 200);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 14;
            label5.Text = "Вывод данных";
            // 
            // ResultTextBox_BVV
            // 
            ResultTextBox_BVV.BackColor = Color.White;
            ResultTextBox_BVV.Location = new Point(24, 228);
            ResultTextBox_BVV.Multiline = true;
            ResultTextBox_BVV.Name = "ResultTextBox_BVV";
            ResultTextBox_BVV.ReadOnly = true;
            ResultTextBox_BVV.ScrollBars = ScrollBars.Vertical;
            ResultTextBox_BVV.Size = new Size(233, 285);
            ResultTextBox_BVV.TabIndex = 15;
            // 
            // ChartFunctionResult_BVV
            // 
            chartArea1.Name = "ChartArea1";
            ChartFunctionResult_BVV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartFunctionResult_BVV.Legends.Add(legend1);
            ChartFunctionResult_BVV.Location = new Point(319, 212);
            ChartFunctionResult_BVV.Name = "ChartFunctionResult_BVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartFunctionResult_BVV.Series.Add(series1);
            ChartFunctionResult_BVV.Size = new Size(1151, 315);
            ChartFunctionResult_BVV.TabIndex = 16;
            title1.Name = "Title1";
            title1.Text = "График функции";
            ChartFunctionResult_BVV.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 539);
            Controls.Add(ChartFunctionResult_BVV);
            Controls.Add(ResultTextBox_BVV);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(SaveButton_BVV);
            Controls.Add(SolveButton_BVV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(InputTextBoxStop_BVV);
            Controls.Add(InputTextBoxStart_BVV);
            Controls.Add(HelpButton_BVV);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1500, 586);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 13 | Бабай К. В.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunctionResult_BVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Button HelpButton_BVV;
        private TextBox InputTextBoxStart_BVV;
        private TextBox InputTextBoxStop_BVV;
        private Label label3;
        private Label label4;
        private Button SolveButton_BVV;
        private Button SaveButton_BVV;
        private TextBox textBox4;
        private Label label5;
        private TextBox ResultTextBox_BVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunctionResult_BVV;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
