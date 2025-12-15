using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BudykovaMM.Sprint7.Project.V12.Lib;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.BudykovaMM.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void перейтиКПапкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";
            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
        }

        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuideModel guideForm = new FormGuideModel();
            guideForm.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 
            }
        }

        private void руководствоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGuidCompany guideForm = new FormGuidCompany();
            guideForm.Show();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddCompany addForm = new FormAddCompany();
            addForm.ShowDialog();
        }
    }
}
