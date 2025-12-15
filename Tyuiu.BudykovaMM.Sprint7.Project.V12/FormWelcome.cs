namespace Tyuiu.BudykovaMM.Sprint7.Project.V12
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void buttonNext_BMM_Click(object sender, EventArgs e)
        {
            FormMain mainForm = new FormMain();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void buttonInfo_BMM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }

      
    }
}
