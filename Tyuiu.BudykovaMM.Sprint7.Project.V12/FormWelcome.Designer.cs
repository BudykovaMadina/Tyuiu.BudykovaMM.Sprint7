namespace Tyuiu.BudykovaMM.Sprint7.Project.V12
{
    partial class FormWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWelcome_BMM = new Label();
            buttonNext_BMM = new Button();
            buttonInfo_BMM = new Button();
            panelWelcomeButtons_BMM = new Panel();
            labelMiddleWelcome_BMM = new Label();
            panelMiddle_BMM = new Panel();
            panel_BMM = new Panel();
            panelWelcomeButtons_BMM.SuspendLayout();
            panelMiddle_BMM.SuspendLayout();
            panel_BMM.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcome_BMM
            // 
            labelWelcome_BMM.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelWelcome_BMM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome_BMM.Location = new Point(127, 75);
            labelWelcome_BMM.Name = "labelWelcome_BMM";
            labelWelcome_BMM.Padding = new Padding(20, 0, 20, 0);
            labelWelcome_BMM.Size = new Size(400, 50);
            labelWelcome_BMM.TabIndex = 0;
            labelWelcome_BMM.Text = "Добро пожаловать в CompCatalog";
            labelWelcome_BMM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonNext_BMM
            // 
            buttonNext_BMM.Anchor = AnchorStyles.None;
            buttonNext_BMM.BackColor = Color.AliceBlue;
            buttonNext_BMM.FlatStyle = FlatStyle.Flat;
            buttonNext_BMM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNext_BMM.Location = new Point(180, 30);
            buttonNext_BMM.Name = "buttonNext_BMM";
            buttonNext_BMM.Size = new Size(122, 39);
            buttonNext_BMM.TabIndex = 2;
            buttonNext_BMM.Text = "Далее";
            buttonNext_BMM.UseVisualStyleBackColor = false;
            buttonNext_BMM.Click += buttonNext_BMM_Click;
            // 
            // buttonInfo_BMM
            // 
            buttonInfo_BMM.Anchor = AnchorStyles.None;
            buttonInfo_BMM.BackColor = Color.AliceBlue;
            buttonInfo_BMM.FlatStyle = FlatStyle.Flat;
            buttonInfo_BMM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_BMM.Location = new Point(317, 30);
            buttonInfo_BMM.Name = "buttonInfo_BMM";
            buttonInfo_BMM.Size = new Size(122, 39);
            buttonInfo_BMM.TabIndex = 3;
            buttonInfo_BMM.Text = "Справка";
            buttonInfo_BMM.UseVisualStyleBackColor = false;
            buttonInfo_BMM.Click += buttonInfo_BMM_Click;
            // 
            // panelWelcomeButtons_BMM
            // 
            panelWelcomeButtons_BMM.Controls.Add(buttonNext_BMM);
            panelWelcomeButtons_BMM.Controls.Add(buttonInfo_BMM);
            panelWelcomeButtons_BMM.Dock = DockStyle.Bottom;
            panelWelcomeButtons_BMM.Location = new Point(0, 207);
            panelWelcomeButtons_BMM.Name = "panelWelcomeButtons_BMM";
            panelWelcomeButtons_BMM.Size = new Size(685, 125);
            panelWelcomeButtons_BMM.TabIndex = 4;
            // 
            // labelMiddleWelcome_BMM
            // 
            labelMiddleWelcome_BMM.Anchor = AnchorStyles.None;
            labelMiddleWelcome_BMM.Font = new Font("Segoe UI", 11F);
            labelMiddleWelcome_BMM.Location = new Point(29, 152);
            labelMiddleWelcome_BMM.Name = "labelMiddleWelcome_BMM";
            labelMiddleWelcome_BMM.Size = new Size(630, 25);
            labelMiddleWelcome_BMM.TabIndex = 5;
            labelMiddleWelcome_BMM.Text = "CompCatalog - Система управления каталогом компьютерной техники";
            // 
            // panelMiddle_BMM
            // 
            panelMiddle_BMM.Controls.Add(labelMiddleWelcome_BMM);
            panelMiddle_BMM.Dock = DockStyle.Fill;
            panelMiddle_BMM.Location = new Point(0, 0);
            panelMiddle_BMM.Name = "panelMiddle_BMM";
            panelMiddle_BMM.Size = new Size(685, 207);
            panelMiddle_BMM.TabIndex = 6;
            // 
            // panel_BMM
            // 
            panel_BMM.Controls.Add(labelWelcome_BMM);
            panel_BMM.Dock = DockStyle.Top;
            panel_BMM.Location = new Point(0, 0);
            panel_BMM.Name = "panel_BMM";
            panel_BMM.Size = new Size(685, 125);
            panel_BMM.TabIndex = 7;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(685, 332);
            Controls.Add(panel_BMM);
            Controls.Add(panelMiddle_BMM);
            Controls.Add(panelWelcomeButtons_BMM);
            MaximizeBox = false;
            MaximumSize = new Size(703, 379);
            MinimumSize = new Size(703, 379);
            Name = "FormWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добро Пожаловать.";
            panelWelcomeButtons_BMM.ResumeLayout(false);
            panelMiddle_BMM.ResumeLayout(false);
            panel_BMM.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelWelcome_BMM;
        private Button buttonNext_BMM;
        private Button buttonInfo_BMM;
        private Panel panelWelcomeButtons_BMM;
        private Label labelMiddleWelcome_BMM;
        private Panel panelMiddle_BMM;
        private Panel panel_BMM;
    }
}
