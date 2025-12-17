namespace Tyuiu.BudykovaMM.Sprint7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelAbout_BMM = new Label();
            pictureBoxPhoto_BMM = new PictureBox();
            buttonOk_BMM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BMM).BeginInit();
            SuspendLayout();
            // 
            // labelAbout_BMM
            // 
            labelAbout_BMM.AutoSize = true;
            labelAbout_BMM.Location = new Point(248, 61);
            labelAbout_BMM.Name = "labelAbout_BMM";
            labelAbout_BMM.Size = new Size(387, 200);
            labelAbout_BMM.TabIndex = 0;
            labelAbout_BMM.Text = resources.GetString("labelAbout_BMM.Text");
            // 
            // pictureBoxPhoto_BMM
            // 
            pictureBoxPhoto_BMM.Image = (Image)resources.GetObject("pictureBoxPhoto_BMM.Image");
            pictureBoxPhoto_BMM.Location = new Point(27, 28);
            pictureBoxPhoto_BMM.Name = "pictureBoxPhoto_BMM";
            pictureBoxPhoto_BMM.Size = new Size(205, 286);
            pictureBoxPhoto_BMM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto_BMM.TabIndex = 1;
            pictureBoxPhoto_BMM.TabStop = false;
            // 
            // buttonOk_BMM
            // 
            buttonOk_BMM.BackColor = Color.AliceBlue;
            buttonOk_BMM.Location = new Point(541, 285);
            buttonOk_BMM.Name = "buttonOk_BMM";
            buttonOk_BMM.Size = new Size(94, 29);
            buttonOk_BMM.TabIndex = 2;
            buttonOk_BMM.Text = "Ок";
            buttonOk_BMM.UseVisualStyleBackColor = false;
            buttonOk_BMM.Click += buttonOk_BMM_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(665, 338);
            Controls.Add(buttonOk_BMM);
            Controls.Add(pictureBoxPhoto_BMM);
            Controls.Add(labelAbout_BMM);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MaximumSize = new Size(683, 385);
            MinimumSize = new Size(683, 385);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BMM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout_BMM;
        private PictureBox pictureBoxPhoto_BMM;
        private Button buttonOk_BMM;
    }
}