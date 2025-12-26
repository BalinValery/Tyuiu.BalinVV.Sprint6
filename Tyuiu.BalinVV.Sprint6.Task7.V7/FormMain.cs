using Tyuiu.BalinVV.Sprint6.Task7.V7.Lib;
using System.ComponentModel;

namespace Tyuiu.BalinVV.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        openFileDialogTask7_BVV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        saveFileDialogMatrix_BVV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void buttonHelp_BVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_BVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask7_BVV.ShowDialog();
            openFilePath = openFileDialogTask7_BVV.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_BVV.ColumnCount = columns;
            dataGridViewInPut_BVV.RowCount = rows;
            dataGridViewOutPut_BVV.ColumnCount = columns;
            dataGridViewOutPut_BVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_BVV.Columns[i].Width = 25;
                dataGridViewOutPut_BVV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_BVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BVV.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_BVV.ColumnCount = 50;
            dataGridViewOutPut_BVV.ColumnCount = 50;

            dataGridViewOutPut_BVV.RowCount = 50;
            dataGridViewInPut_BVV.RowCount = 50;

            panelInPut_BVV.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_BVV.Columns[i].Width = 25;
                dataGridViewOutPut_BVV.Columns[i].Width = 25;
            }
        }
        private void buttonDone_BVV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_BVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_BVV.Enabled = true;
        }
        private void buttonSaveFile_BVV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BVV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BVV.ShowDialog();

            string path = saveFileDialogMatrix_BVV.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_BVV.RowCount;
            int columns = dataGridViewOutPut_BVV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_BVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_BVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BVV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BVV.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BVV.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BVV.ToolTipTitle = "Справка";
        }

        private void openFileDialogTask7_BVV_FileOk(object sender, CancelEventArgs e)
        {

        }


    }
}
