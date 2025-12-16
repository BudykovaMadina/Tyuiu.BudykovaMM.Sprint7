namespace Tyuiu.BudykovaMM.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip_BMM = new MenuStrip();
            программаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            базаДанныхToolStripMenuItem = new ToolStripMenuItem();
            перейтиКПапкеToolStripMenuItem = new ToolStripMenuItem();
            добавитьСвоюМодельToolStripMenuItem = new ToolStripMenuItem();
            руководствоToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            добавитьСвоюФирмуToolStripMenuItem = new ToolStripMenuItem();
            руководствоToolStripMenuItem1 = new ToolStripMenuItem();
            добавитьToolStripMenuItem1 = new ToolStripMenuItem();
            groupBoxData_BMM = new GroupBox();
            radioButtonProcessorFrequency_BMM = new RadioButton();
            radioButtonRAM_BMM = new RadioButton();
            radioButtonSSD_BMM = new RadioButton();
            radioButtonScreenSize_BMM = new RadioButton();
            radioButtonProcessor_BMM = new RadioButton();
            radioButtonDiagonal_BMM = new RadioButton();
            buttonLoadData_BMM = new Button();
            buttonDone_BMM = new Button();
            buttonShowShopInfo_BMM = new Button();
            comboBoxName_BMM = new ComboBox();
            comboBoxModel_BMM = new ComboBox();
            buttonShowModels_BMM = new Button();
            labelModel_BMM = new Label();
            labelfirma_BMM = new Label();
            textBoxShopInfo_BMM = new TextBox();
            groupBoxPrice_BMM = new GroupBox();
            dataGridViewPrice_BMM = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            bindingSourcePrice_BMM = new BindingSource(components);
            groupBoxShopInfo_BMM = new GroupBox();
            groupBoxResult_BMM = new GroupBox();
            textBoxRes_BMM = new TextBox();
            menuStrip_BMM.SuspendLayout();
            groupBoxData_BMM.SuspendLayout();
            groupBoxPrice_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrice_BMM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePrice_BMM).BeginInit();
            groupBoxShopInfo_BMM.SuspendLayout();
            groupBoxResult_BMM.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_BMM
            // 
            menuStrip_BMM.BackColor = Color.AliceBlue;
            menuStrip_BMM.ImageScalingSize = new Size(20, 20);
            menuStrip_BMM.Items.AddRange(new ToolStripItem[] { программаToolStripMenuItem, базаДанныхToolStripMenuItem });
            menuStrip_BMM.Location = new Point(0, 0);
            menuStrip_BMM.Name = "menuStrip_BMM";
            menuStrip_BMM.Size = new Size(907, 28);
            menuStrip_BMM.TabIndex = 0;
            // 
            // программаToolStripMenuItem
            // 
            программаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, выходToolStripMenuItem });
            программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            программаToolStripMenuItem.Size = new Size(105, 24);
            программаToolStripMenuItem.Text = "Программа";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(187, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(187, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // базаДанныхToolStripMenuItem
            // 
            базаДанныхToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { перейтиКПапкеToolStripMenuItem, добавитьСвоюМодельToolStripMenuItem, добавитьСвоюФирмуToolStripMenuItem });
            базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            базаДанныхToolStripMenuItem.Size = new Size(111, 24);
            базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // перейтиКПапкеToolStripMenuItem
            // 
            перейтиКПапкеToolStripMenuItem.Name = "перейтиКПапкеToolStripMenuItem";
            перейтиКПапкеToolStripMenuItem.Size = new Size(255, 26);
            перейтиКПапкеToolStripMenuItem.Text = "Перейти к папке";
            перейтиКПапкеToolStripMenuItem.Click += перейтиКПапкеToolStripMenuItem_Click;
            // 
            // добавитьСвоюМодельToolStripMenuItem
            // 
            добавитьСвоюМодельToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { руководствоToolStripMenuItem, добавитьToolStripMenuItem });
            добавитьСвоюМодельToolStripMenuItem.Name = "добавитьСвоюМодельToolStripMenuItem";
            добавитьСвоюМодельToolStripMenuItem.Size = new Size(255, 26);
            добавитьСвоюМодельToolStripMenuItem.Text = "Добавить свою модель";
            // 
            // руководствоToolStripMenuItem
            // 
            руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            руководствоToolStripMenuItem.Size = new Size(178, 26);
            руководствоToolStripMenuItem.Text = "Руководство";
            руководствоToolStripMenuItem.Click += руководствоToolStripMenuItem_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(178, 26);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // добавитьСвоюФирмуToolStripMenuItem
            // 
            добавитьСвоюФирмуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { руководствоToolStripMenuItem1, добавитьToolStripMenuItem1 });
            добавитьСвоюФирмуToolStripMenuItem.Name = "добавитьСвоюФирмуToolStripMenuItem";
            добавитьСвоюФирмуToolStripMenuItem.Size = new Size(255, 26);
            добавитьСвоюФирмуToolStripMenuItem.Text = "Добавить свою фирму";
            // 
            // руководствоToolStripMenuItem1
            // 
            руководствоToolStripMenuItem1.Name = "руководствоToolStripMenuItem1";
            руководствоToolStripMenuItem1.Size = new Size(178, 26);
            руководствоToolStripMenuItem1.Text = "Руководство";
            руководствоToolStripMenuItem1.Click += руководствоToolStripMenuItem1_Click;
            // 
            // добавитьToolStripMenuItem1
            // 
            добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            добавитьToolStripMenuItem1.Size = new Size(178, 26);
            добавитьToolStripMenuItem1.Text = "Добавить";
            добавитьToolStripMenuItem1.Click += добавитьToolStripMenuItem1_Click;
            // 
            // groupBoxData_BMM
            // 
            groupBoxData_BMM.Controls.Add(radioButtonProcessorFrequency_BMM);
            groupBoxData_BMM.Controls.Add(radioButtonRAM_BMM);
            groupBoxData_BMM.Controls.Add(radioButtonSSD_BMM);
            groupBoxData_BMM.Controls.Add(radioButtonScreenSize_BMM);
            groupBoxData_BMM.Controls.Add(radioButtonProcessor_BMM);
            groupBoxData_BMM.Controls.Add(radioButtonDiagonal_BMM);
            groupBoxData_BMM.Controls.Add(buttonLoadData_BMM);
            groupBoxData_BMM.Controls.Add(buttonDone_BMM);
            groupBoxData_BMM.Controls.Add(buttonShowShopInfo_BMM);
            groupBoxData_BMM.Controls.Add(comboBoxName_BMM);
            groupBoxData_BMM.Controls.Add(comboBoxModel_BMM);
            groupBoxData_BMM.Controls.Add(buttonShowModels_BMM);
            groupBoxData_BMM.Controls.Add(labelModel_BMM);
            groupBoxData_BMM.Controls.Add(labelfirma_BMM);
            groupBoxData_BMM.Location = new Point(12, 31);
            groupBoxData_BMM.Name = "groupBoxData_BMM";
            groupBoxData_BMM.Size = new Size(883, 267);
            groupBoxData_BMM.TabIndex = 1;
            groupBoxData_BMM.TabStop = false;
            groupBoxData_BMM.Text = "Ввод данных";
            // 
            // radioButtonProcessorFrequency_BMM
            // 
            radioButtonProcessorFrequency_BMM.AutoSize = true;
            radioButtonProcessorFrequency_BMM.Location = new Point(286, 213);
            radioButtonProcessorFrequency_BMM.Name = "radioButtonProcessorFrequency_BMM";
            radioButtonProcessorFrequency_BMM.Size = new Size(167, 24);
            radioButtonProcessorFrequency_BMM.TabIndex = 19;
            radioButtonProcessorFrequency_BMM.TabStop = true;
            radioButtonProcessorFrequency_BMM.Text = "Процессор, частота";
            radioButtonProcessorFrequency_BMM.UseVisualStyleBackColor = true;
            // 
            // radioButtonRAM_BMM
            // 
            radioButtonRAM_BMM.AutoSize = true;
            radioButtonRAM_BMM.Location = new Point(286, 183);
            radioButtonRAM_BMM.Name = "radioButtonRAM_BMM";
            radioButtonRAM_BMM.Size = new Size(177, 24);
            radioButtonRAM_BMM.TabIndex = 18;
            radioButtonRAM_BMM.TabStop = true;
            radioButtonRAM_BMM.Text = "Оперативная память";
            radioButtonRAM_BMM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSSD_BMM
            // 
            radioButtonSSD_BMM.AutoSize = true;
            radioButtonSSD_BMM.Location = new Point(286, 153);
            radioButtonSSD_BMM.Name = "radioButtonSSD_BMM";
            radioButtonSSD_BMM.Size = new Size(109, 24);
            radioButtonSSD_BMM.TabIndex = 17;
            radioButtonSSD_BMM.TabStop = true;
            radioButtonSSD_BMM.Text = "Объём SSD";
            radioButtonSSD_BMM.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreenSize_BMM
            // 
            radioButtonScreenSize_BMM.AutoSize = true;
            radioButtonScreenSize_BMM.Location = new Point(26, 213);
            radioButtonScreenSize_BMM.Name = "radioButtonScreenSize_BMM";
            radioButtonScreenSize_BMM.Size = new Size(168, 24);
            radioButtonScreenSize_BMM.TabIndex = 16;
            radioButtonScreenSize_BMM.TabStop = true;
            radioButtonScreenSize_BMM.Text = "Разрешение экрана";
            radioButtonScreenSize_BMM.UseVisualStyleBackColor = true;
            // 
            // radioButtonProcessor_BMM
            // 
            radioButtonProcessor_BMM.AutoSize = true;
            radioButtonProcessor_BMM.Location = new Point(26, 183);
            radioButtonProcessor_BMM.Name = "radioButtonProcessor_BMM";
            radioButtonProcessor_BMM.Size = new Size(108, 24);
            radioButtonProcessor_BMM.TabIndex = 15;
            radioButtonProcessor_BMM.TabStop = true;
            radioButtonProcessor_BMM.Text = "Процессор";
            radioButtonProcessor_BMM.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiagonal_BMM
            // 
            radioButtonDiagonal_BMM.AutoSize = true;
            radioButtonDiagonal_BMM.Location = new Point(26, 153);
            radioButtonDiagonal_BMM.Name = "radioButtonDiagonal_BMM";
            radioButtonDiagonal_BMM.Size = new Size(228, 24);
            radioButtonDiagonal_BMM.TabIndex = 14;
            radioButtonDiagonal_BMM.TabStop = true;
            radioButtonDiagonal_BMM.Text = "Диагональ экрана в дюймах";
            radioButtonDiagonal_BMM.UseVisualStyleBackColor = true;
            // 
            // buttonLoadData_BMM
            // 
            buttonLoadData_BMM.BackColor = Color.AliceBlue;
            buttonLoadData_BMM.Location = new Point(786, 209);
            buttonLoadData_BMM.Name = "buttonLoadData_BMM";
            buttonLoadData_BMM.Size = new Size(57, 48);
            buttonLoadData_BMM.TabIndex = 13;
            buttonLoadData_BMM.Text = "Prise";
            buttonLoadData_BMM.UseVisualStyleBackColor = false;
            // 
            // buttonDone_BMM
            // 
            buttonDone_BMM.BackColor = Color.AliceBlue;
            buttonDone_BMM.Enabled = false;
            buttonDone_BMM.Location = new Point(786, 98);
            buttonDone_BMM.Name = "buttonDone_BMM";
            buttonDone_BMM.Size = new Size(57, 48);
            buttonDone_BMM.TabIndex = 6;
            buttonDone_BMM.Text = "done";
            buttonDone_BMM.UseVisualStyleBackColor = false;
            buttonDone_BMM.Click += buttonDone_BMM_Click;
            // 
            // buttonShowShopInfo_BMM
            // 
            buttonShowShopInfo_BMM.BackColor = Color.AliceBlue;
            buttonShowShopInfo_BMM.Location = new Point(786, 152);
            buttonShowShopInfo_BMM.Name = "buttonShowShopInfo_BMM";
            buttonShowShopInfo_BMM.Size = new Size(57, 48);
            buttonShowShopInfo_BMM.TabIndex = 5;
            buttonShowShopInfo_BMM.Text = "info shop";
            buttonShowShopInfo_BMM.UseVisualStyleBackColor = false;
            buttonShowShopInfo_BMM.Click += buttonShowShopInfo_BMM_Click;
            // 
            // comboBoxName_BMM
            // 
            comboBoxName_BMM.FormattingEnabled = true;
            comboBoxName_BMM.Location = new Point(12, 109);
            comboBoxName_BMM.Name = "comboBoxName_BMM";
            comboBoxName_BMM.Size = new Size(736, 28);
            comboBoxName_BMM.TabIndex = 4;
            // 
            // comboBoxModel_BMM
            // 
            comboBoxModel_BMM.FormattingEnabled = true;
            comboBoxModel_BMM.Location = new Point(12, 54);
            comboBoxModel_BMM.Name = "comboBoxModel_BMM";
            comboBoxModel_BMM.Size = new Size(736, 28);
            comboBoxModel_BMM.TabIndex = 3;
            // 
            // buttonShowModels_BMM
            // 
            buttonShowModels_BMM.BackColor = Color.AliceBlue;
            buttonShowModels_BMM.Location = new Point(786, 43);
            buttonShowModels_BMM.Name = "buttonShowModels_BMM";
            buttonShowModels_BMM.Size = new Size(57, 48);
            buttonShowModels_BMM.TabIndex = 2;
            buttonShowModels_BMM.Text = "show ";
            buttonShowModels_BMM.UseVisualStyleBackColor = false;
            buttonShowModels_BMM.Click += buttonShowModels_BMM_Click;
            // 
            // labelModel_BMM
            // 
            labelModel_BMM.AutoSize = true;
            labelModel_BMM.Location = new Point(12, 86);
            labelModel_BMM.Name = "labelModel_BMM";
            labelModel_BMM.Size = new Size(180, 20);
            labelModel_BMM.TabIndex = 1;
            labelModel_BMM.Text = "Выберите модель ПЭВМ";
            // 
            // labelfirma_BMM
            // 
            labelfirma_BMM.AutoSize = true;
            labelfirma_BMM.Location = new Point(12, 28);
            labelfirma_BMM.Name = "labelfirma_BMM";
            labelfirma_BMM.Size = new Size(241, 20);
            labelfirma_BMM.TabIndex = 0;
            labelfirma_BMM.Text = "Выберите фирму-производитель";
            // 
            // textBoxShopInfo_BMM
            // 
            textBoxShopInfo_BMM.BackColor = Color.AliceBlue;
            textBoxShopInfo_BMM.Location = new Point(6, 25);
            textBoxShopInfo_BMM.Multiline = true;
            textBoxShopInfo_BMM.Name = "textBoxShopInfo_BMM";
            textBoxShopInfo_BMM.ReadOnly = true;
            textBoxShopInfo_BMM.Size = new Size(532, 188);
            textBoxShopInfo_BMM.TabIndex = 2;
            // 
            // groupBoxPrice_BMM
            // 
            groupBoxPrice_BMM.Controls.Add(dataGridViewPrice_BMM);
            groupBoxPrice_BMM.Location = new Point(15, 349);
            groupBoxPrice_BMM.Name = "groupBoxPrice_BMM";
            groupBoxPrice_BMM.Size = new Size(330, 242);
            groupBoxPrice_BMM.TabIndex = 3;
            groupBoxPrice_BMM.TabStop = false;
            groupBoxPrice_BMM.Text = "Сведения о цене ($)";
            // 
            // dataGridViewPrice_BMM
            // 
            dataGridViewPrice_BMM.BackgroundColor = Color.AliceBlue;
            dataGridViewPrice_BMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrice_BMM.Columns.AddRange(new DataGridViewColumn[] { Name, Price });
            dataGridViewPrice_BMM.Location = new Point(12, 35);
            dataGridViewPrice_BMM.Name = "dataGridViewPrice_BMM";
            dataGridViewPrice_BMM.ReadOnly = true;
            dataGridViewPrice_BMM.RowHeadersVisible = false;
            dataGridViewPrice_BMM.RowHeadersWidth = 51;
            dataGridViewPrice_BMM.ScrollBars = ScrollBars.Vertical;
            dataGridViewPrice_BMM.Size = new Size(300, 188);
            dataGridViewPrice_BMM.TabIndex = 0;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 245;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 55;
            // 
            // groupBoxShopInfo_BMM
            // 
            groupBoxShopInfo_BMM.Controls.Add(textBoxShopInfo_BMM);
            groupBoxShopInfo_BMM.Location = new Point(351, 359);
            groupBoxShopInfo_BMM.Name = "groupBoxShopInfo_BMM";
            groupBoxShopInfo_BMM.Size = new Size(544, 232);
            groupBoxShopInfo_BMM.TabIndex = 4;
            groupBoxShopInfo_BMM.TabStop = false;
            groupBoxShopInfo_BMM.Text = "Сведения о производителе";
            // 
            // groupBoxResult_BMM
            // 
            groupBoxResult_BMM.Controls.Add(textBoxRes_BMM);
            groupBoxResult_BMM.Location = new Point(12, 294);
            groupBoxResult_BMM.Name = "groupBoxResult_BMM";
            groupBoxResult_BMM.Size = new Size(883, 59);
            groupBoxResult_BMM.TabIndex = 5;
            groupBoxResult_BMM.TabStop = false;
            groupBoxResult_BMM.Text = "Результат поиска";
            // 
            // textBoxRes_BMM
            // 
            textBoxRes_BMM.Location = new Point(12, 24);
            textBoxRes_BMM.Name = "textBoxRes_BMM";
            textBoxRes_BMM.ReadOnly = true;
            textBoxRes_BMM.Size = new Size(736, 27);
            textBoxRes_BMM.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(907, 603);
            Controls.Add(groupBoxResult_BMM);
            Controls.Add(groupBoxShopInfo_BMM);
            Controls.Add(groupBoxPrice_BMM);
            Controls.Add(groupBoxData_BMM);
            Controls.Add(menuStrip_BMM);
            MainMenuStrip = menuStrip_BMM;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompCatalog";
            menuStrip_BMM.ResumeLayout(false);
            menuStrip_BMM.PerformLayout();
            groupBoxData_BMM.ResumeLayout(false);
            groupBoxData_BMM.PerformLayout();
            groupBoxPrice_BMM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrice_BMM).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePrice_BMM).EndInit();
            groupBoxShopInfo_BMM.ResumeLayout(false);
            groupBoxShopInfo_BMM.PerformLayout();
            groupBoxResult_BMM.ResumeLayout(false);
            groupBoxResult_BMM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_BMM;
        private ToolStripMenuItem программаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem базаДанныхToolStripMenuItem;
        private ToolStripMenuItem перейтиКПапкеToolStripMenuItem;
        private ToolStripMenuItem добавитьСвоюМодельToolStripMenuItem;
        private ToolStripMenuItem руководствоToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem добавитьСвоюФирмуToolStripMenuItem;
        private ToolStripMenuItem руководствоToolStripMenuItem1;
        private ToolStripMenuItem добавитьToolStripMenuItem1;
        private GroupBox groupBoxData_BMM;
        private Label labelfirma_BMM;
        private Label labelModel_BMM;
        private Button buttonShowModels_BMM;
        private ComboBox comboBoxModel_BMM;
        private TextBox textBoxShopInfo_BMM;
        private GroupBox groupBoxPrice_BMM;
        private ComboBox comboBoxName_BMM;
        private Button buttonDone_BMM;
        private Button buttonShowShopInfo_BMM;
        private BindingSource bindingSourcePrice_BMM;
        private DataGridView dataGridViewPrice_BMM;
        private Button buttonLoadData_BMM;
        private GroupBox groupBoxShopInfo_BMM;
        private GroupBox groupBoxResult_BMM;
        private TextBox textBoxRes_BMM;
        private RadioButton radioButtonProcessorFrequency_BMM;
        private RadioButton radioButtonRAM_BMM;
        private RadioButton radioButtonSSD_BMM;
        private RadioButton radioButtonScreenSize_BMM;
        private RadioButton radioButtonProcessor_BMM;
        private RadioButton radioButtonDiagonal_BMM;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
    }
}