using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BalinVV.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line_i[j]);
                }
            }

            for (int j = 0; j < rows; j++)
            {
                if (matrix[4, j] % 2 != 0)
                {
                    matrix[4, j] = 66;
                }
            }
            return matrix;
        }
    }
}
     
