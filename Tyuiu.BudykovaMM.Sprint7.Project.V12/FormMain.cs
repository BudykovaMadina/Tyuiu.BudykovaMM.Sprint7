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

        private void buttonShowModels_BMM_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBoxName_BMM.Text);
            try
            {
                string path = $@"C:\DataSprint7\{name}InPutFile.csv";
                string fileData = File.ReadAllText(path);
                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int rows = lines.Length;
                int columns = lines[0].Split(';').Length;

                // Î÷èñòêà êîìáîáîêñà ïåðåä çàïîëíåíèåì
                comboBoxModel_BMM.Items.Clear();

                for (int i = 1; i < rows; i++)
                {
                    // Ïîëó÷àåì ìîäåëü èç ôàéëà è äîáàâëÿåì â êîìáîáîêñ
                    string model = ds.CollectTextFromFileInt(path, i, 0);
                    comboBoxModel_BMM.Items.Add(model); // Äîáàâëÿåì ìîäåëü â êîìáîáîêñ
                    textBoxShopInfo_BMM.Text += model + Environment.NewLine;
                }

                textBoxShopInfo_BMM.Text += "--------------------" + Environment.NewLine;
                buttonDone_BMM.Enabled = true;
                comboBoxModel_BMM.Enabled = true; // Âêëþ÷àåì êîìáîáîêñ
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            string name = Convert.ToString(comboBoxName_BMM.Text); // Ïîëó÷àåì èìÿ èç comboBox
            string path = $@"C:\DataSprint7\{name}Price.csv"; // Ôîðìèðóåì ïóòü ê ôàéëó

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Ôàéë ñ äàííûìè î öåíàõ íå íàéäåí.", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ×òåíèå äàííûõ èç ôàéëà
                var models = new List<ComputerModel>();
                string[] lines = File.ReadAllLines(path);

                for (int i = 1; i < lines.Length; i++) // Íà÷èíàåì ñ 1 äëÿ ïðîïóñêà çàãîëîâêà
                {
                    var columns = lines[i].Split(';');
                    if (columns.Length >= 2)
                    {
                        string modelName = columns[0]; // Íàçâàíèå ìîäåëè
                        double price = Convert.ToDouble(columns[1]); // Öåíà ìîäåëè
                        models.Add(new ComputerModel { Name = modelName, Price = price });
                    }
                }

                bindingSourcePrice_BMM.DataSource = models; // Óñòàíàâëèâàåì èñòî÷íèê äàííûõ
                dataGridViewPrice_BMM.DataSource = bindingSourcePrice_BMM; // Ñâÿçûâàåì ñ DataGridView
                dataGridViewPrice_BMM.Columns["Name"].Width = 258; // Óñòàíîâèòå øèðèíó êîëîíêè äëÿ íàçâàíèÿ ìîäåëè
                dataGridViewPrice_BMM.Columns["Price"].Width = 50; // Óñòàíîâèòå øèðèíó êîëîíêè äëÿ öåíû
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Îøèáêà ïðè çàãðóçêå äàííûõ: {ex.Message}", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_BMM_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBoxName_BMM.Text);
            try
            {
                string path = $@"C:\DataSprint7\{name}InPutFile.csv";

                // Ïîëó÷àåì âûáðàííóþ ìîäåëü èç êîìáîáîêñà
                string selectedModel = Convert.ToString(comboBoxModel_BMM.SelectedItem);

                if (radioButtonDiagonal_BMM.Checked)
                {
                    textBoxRes_BMM.Text = ds.CollectTextFromFile(path, selectedModel, 1);
                }
                else if (radioButtonScreenSize_BMM.Checked)
                {
                    textBoxRes_BMM.Text = ds.CollectTextFromFile(path, selectedModel, 2);
                }
                else if (radioButtonRAM_BMM.Checked)
                {
                    textBoxRes_BMM.Text = ds.CollectTextFromFile(path, selectedModel, 3);
                }
                else if (radioButtonSSD_BMM.Checked)
                {
                    textBoxRes_BMM.Text = ds.CollectTextFromFile(path, selectedModel, 4);
                }
                else if (radioButtonProcessor_BMM.Checked)
                {
                    textBoxRes_BMM.Text = ds.CollectTextFromFile(path, selectedModel, 5);
                }
                else if (radioButtonProcessorFrequency_BMM.Checked)
                {
                    textBoxRes_BMM.Text = ds.CollectTextFromFile(path, selectedModel, 6);
                }
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public class ComputerModel
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        private void buttonShowShopInfo_BMM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DataSprint7\ShopsInPutFile.csv";
                textBoxShopInfo_BMM.Text = ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_BMM.Text), 1) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_BMM.Text), 2) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_BMM.Text), 3) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_BMM.Text), 4);
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadData_BMM_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
