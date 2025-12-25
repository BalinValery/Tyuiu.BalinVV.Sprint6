using Tyuiu.BalinVV.Sprint6.Task6.V13.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        private void buttonHelp_ClickBVV(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonLoad_ClickBVV(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            buttonDone.Enabled = true;
        }
        DataService ds = new DataService();
        private void buttonDone_ClickBVV(object sender, EventArgs e)
        {

            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
    

