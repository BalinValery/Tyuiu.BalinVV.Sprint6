using Tyuiu.BalinVV.Sprint6.Task1.V13.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task1.V13
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        
            DataService ds = new DataService();
            private void buttonDown_BVV_Click(object sender, EventArgs e);
            
           {
             try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_BVV.Text);
        int stopValue = Convert.ToInt32(textBoxStopValue_BVV.Text);

        string strLine;
        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] res = new double[len];
        res = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_BVV.Text = "";
                textBoxResult_BVV.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxResult_BVV.AppendText("|    X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_BVV.AppendText("+---------+----------+" + Environment.NewLine);
                for (int i = 0; i<len; i++)
                {
                    strLine = String.Format("|{0,5:d}    | {1, 6:f2}   | ", startValue, res[i]);
                    textBoxResult_BVV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
    textBoxResult_BVV.AppendText("+---------+----------+");
            }
            catch
            {
    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
        
        }
        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
{
    MessageBox.Show("Òàñê 1 Âàðèàíò 13  CÌÀÐÒá-25-1");
}
    }
}
