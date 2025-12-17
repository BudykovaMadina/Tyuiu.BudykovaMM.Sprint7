namespace Tyuiu.BudykovaMM.Sprint7.Project.V12
{
    partial class FormGuideModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuideModel));
            panel1 = new Panel();
            pictureBoxInfoModel_BMM = new PictureBox();
            labelInfo_BMM = new Label();
            panel2 = new Panel();
            labelInfoTwice_BMM = new Label();
            pictureBoxInfoModelMIddle_BMM = new PictureBox();
            panel3 = new Panel();
            labelInfoModelMiddle_BMM = new Label();
            panel4 = new Panel();
            labelInfoModelBotton_BMM = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoModel_BMM).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoModelMIddle_BMM).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxInfoModel_BMM);
            panel1.Controls.Add(labelInfo_BMM);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 200);
            panel1.TabIndex = 0;
            // 
            // pictureBoxInfoModel_BMM
            // 
            pictureBoxInfoModel_BMM.Image = (Image)resources.GetObject("pictureBoxInfoModel_BMM.Image");
            pictureBoxInfoModel_BMM.Location = new Point(12, 70);
            pictureBoxInfoModel_BMM.Name = "pictureBoxInfoModel_BMM";
            pictureBoxInfoModel_BMM.Size = new Size(765, 114);
            pictureBoxInfoModel_BMM.TabIndex = 1;
            pictureBoxInfoModel_BMM.TabStop = false;
            // 
            // labelInfo_BMM
            // 
            labelInfo_BMM.BackColor = Color.Lavender;
            labelInfo_BMM.Location = new Point(12, 9);
            labelInfo_BMM.MaximumSize = new Size(861, 41);
            labelInfo_BMM.MinimumSize = new Size(861, 41);
            labelInfo_BMM.Name = "labelInfo_BMM";
            labelInfo_BMM.Size = new Size(861, 41);
            labelInfo_BMM.TabIndex = 0;
            labelInfo_BMM.Text = "Нажмите на кнопку \"Добавить\". Откроется новое окно, в котором вы увидите файлы с доступными фирмами-производителями. ";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelInfoTwice_BMM);
            panel2.Controls.Add(pictureBoxInfoModelMIddle_BMM);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 199);
            panel2.TabIndex = 1;
            // 
            // labelInfoTwice_BMM
            // 
            labelInfoTwice_BMM.Location = new Point(12, 20);
            labelInfoTwice_BMM.Name = "labelInfoTwice_BMM";
            labelInfoTwice_BMM.Size = new Size(861, 49);
            labelInfoTwice_BMM.TabIndex = 1;
            labelInfoTwice_BMM.Text = resources.GetString("labelInfoTwice_BMM.Text");
            // 
            // pictureBoxInfoModelMIddle_BMM
            // 
            pictureBoxInfoModelMIddle_BMM.Image = (Image)resources.GetObject("pictureBoxInfoModelMIddle_BMM.Image");
            pictureBoxInfoModelMIddle_BMM.Location = new Point(12, 83);
            pictureBoxInfoModelMIddle_BMM.Name = "pictureBoxInfoModelMIddle_BMM";
            pictureBoxInfoModelMIddle_BMM.Size = new Size(756, 88);
            pictureBoxInfoModelMIddle_BMM.TabIndex = 0;
            pictureBoxInfoModelMIddle_BMM.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelInfoModelMiddle_BMM);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 399);
            panel3.Name = "panel3";
            panel3.Size = new Size(907, 204);
            panel3.TabIndex = 2;
            // 
            // labelInfoModelMiddle_BMM
            // 
            labelInfoModelMiddle_BMM.Location = new Point(12, 32);
            labelInfoModelMiddle_BMM.Name = "labelInfoModelMiddle_BMM";
            labelInfoModelMiddle_BMM.Size = new Size(861, 55);
            labelInfoModelMiddle_BMM.TabIndex = 1;
            labelInfoModelMiddle_BMM.Text = "В открывшемся файле добавьте новую строку по следующему шаблону:\r\nМодель;Диагональ экрана в дюймах;Разрешение экрана;Оперативная память;Объем SSD;Процессор;Процессор, частота";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelInfoModelBotton_BMM);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 483);
            panel4.Name = "panel4";
            panel4.Size = new Size(907, 120);
            panel4.TabIndex = 3;
            // 
            // labelInfoModelBotton_BMM
            // 
            labelInfoModelBotton_BMM.Location = new Point(12, 28);
            labelInfoModelBotton_BMM.Name = "labelInfoModelBotton_BMM";
            labelInfoModelBotton_BMM.Size = new Size(861, 62);
            labelInfoModelBotton_BMM.TabIndex = 1;
            labelInfoModelBotton_BMM.Text = resources.GetString("labelInfoModelBotton_BMM.Text");
            // 
            // FormGuideModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(907, 603);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(925, 650);
            MinimumSize = new Size(925, 650);
            Name = "FormGuideModel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Руководство";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoModel_BMM).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoModelMIddle_BMM).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label labelInfo_BMM;
        private PictureBox pictureBoxInfoModel_BMM;
        private Label labelInfoTwice_BMM;
        private PictureBox pictureBoxInfoModelMIddle_BMM;
        private Label labelInfoModelMiddle_BMM;
        private Label labelInfoModelBotton_BMM;
    }
}