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

                // Очистка комбобокса перед заполнением
                comboBoxModel_BMM.Items.Clear();

                for (int i = 1; i < rows; i++)
                {
                    // Получаем модель из файла и добавляем в комбобокс
                    string model = ds.CollectTextFromFileInt(path, i, 0);
                    comboBoxModel_BMM.Items.Add(model);
                }

                buttonDone_BMM.Enabled = true;
                comboBoxModel_BMM.Enabled = true; // включаем комбобокс
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            string name = Convert.ToString(comboBoxName_BMM.Text); // получаем имя из comboBox
            string path = $@"C:\DataSprint7\{name}Price.csv"; // Формируем путь к файлу

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл с данными о ценах не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Чтение данных из файла
                var models = new List<ComputerModel>();
                string[] lines = File.ReadAllLines(path);

                for (int i = 1; i < lines.Length; i++)
                {
                    var columns = lines[i].Split(';');
                    if (columns.Length >= 2)
                    {
                        string modelName = columns[0];
                        double price = Convert.ToDouble(columns[1]);
                        models.Add(new ComputerModel { Name = modelName, Price = price });
                    }
                }

                bindingSourcePrice_BMM.DataSource = models;
                dataGridViewPrice_BMM.DataSource = bindingSourcePrice_BMM;
                dataGridViewPrice_BMM.Columns["Name"].Width = 258;
                dataGridViewPrice_BMM.Columns["Price"].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_BMM_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBoxName_BMM.Text);
            try
            {
                string path = $@"C:\DataSprint7\{name}InPutFile.csv";


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
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadData_BMM_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 
            }
        }
    }
}
