namespace Tyuiu.BalinVV.Sprint6.Task6.V13
{
    partial class FormAbout
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
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            buttonOK = new Button();
            SuspendLayout();
            
            textBox1.Location = new Point(0, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(233, 195);
            textBox1.TabIndex = 0;
            textBox1.Text = "Разработчик:\r\nБалин В.В.\r\n\r\nГруппа:\r\nСМАРТБ-25-1\r\n\r\nСпринт 6 \r\nЗадание 6 \r\nВариант 13";
            
            buttonOK.BackColor = Color.MediumSeaGreen;
            buttonOK.FlatStyle = FlatStyle.Popup;
            buttonOK.Location = new Point(139, 250);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 291);
            Controls.Add(buttonOK);
            Controls.Add(textBox1);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

#endregion

        private TextBox textBox1;
        private Button buttonOK;
    }
}
        
 