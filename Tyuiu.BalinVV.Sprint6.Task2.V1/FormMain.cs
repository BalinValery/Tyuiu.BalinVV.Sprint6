using Tyuiu.BalinVV.Sprint6.Task2.V1.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task2.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = ButtonResultBVV;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {

            try
            {
                int startStep = Convert.ToInt32(TextBoxStartStepBVV.Text);
                int stopStep = Convert.ToInt32(TextBoxStopStepBVV.Text);

                double[] res = ds.GetMassFunction(startStep, stopStep);
                string line;
                TextBoxResultBVV.Text = "";
                TextBoxResultBVV.AppendText("+-------+--------+" + Environment.NewLine);
                TextBoxResultBVV.AppendText("|    x       |       f(x)  |" + Environment.NewLine);
                TextBoxResultBVV.AppendText("+-------+--------+" + Environment.NewLine);
                for (int i = 0; i < res.Length; i++)
                {
                    Console.WriteLine(res[i]);
                    line = String.Format("|{0,5:d}       |   {1,5:f2}     |", startStep + i, res[i]);
                    TextBoxResultBVV.AppendText(line + Environment.NewLine);
                }
                TextBoxResultBVV.AppendText("+-------+--------+" + Environment.NewLine);

            }
            catch
            {

                MessageBox.Show("Введены неверные данные ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Выполнил Балин Валерий СМАРТб-25-1", "");


        }

        private void TextBoxStartStepBVV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        }
    }
}
