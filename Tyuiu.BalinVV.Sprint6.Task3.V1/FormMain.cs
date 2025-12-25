using Tyuiu.BalinVV.Sprint6.Task3.V1.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task3.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { 25, 20, 28, 2, 6 },
                                      { 19, 9, 18, -7, 24 },
                                      { 21, 16, 5, -7, -8 },
                                      { 30, -13, 1, -15, 2 },
                                      { 31, 9, -3, -9, -18 } };
        private void buttonDone_ClickBVV(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewResultBVV.ColumnCount = columns;
            dataGridViewResultBVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultBVV.Columns[i].Width = 25;
            }
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResultBVV.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_ClickBVV(object sender, EventArgs e)
        {
            MessageBox.Show("Таск3 Выполнил Балин В.В. СМАРТб-25-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrixBVV.ColumnCount = columns;
            dataGridViewMatrixBVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixBVV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixBVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void groupBoxInputData_EnterBVV(object sender, EventArgs e)
        {

        }
    }
}
  