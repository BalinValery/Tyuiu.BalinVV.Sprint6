using Tyuiu.BalinVV.Sprint6.Task5.V9.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint6\Tyuiu.BalinVV.Sprint6.Task5.V9\bin\Debug\InPutDataFileTask5V9.txt";

        private void buttonResult_BVV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BVV.ColumnCount = 2;
            dataGridViewResult_BVV.Columns[0].Width = 20;
            dataGridViewResult_BVV.Columns[1].Width = 50;

            this.chartResult_BVV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_BVV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_BVV.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_BVV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_BVV.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_BVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_BVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-25-1 Балин В.В.", "Сообщение");
        }
    }
}
   