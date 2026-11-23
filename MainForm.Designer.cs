namespace GymWorkoutFormProject
{
    partial class MainForm
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
            MainMenuStrip1 = new MenuStrip();
            InputDataMI = new ToolStripMenuItem();
            MemberMI = new ToolStripMenuItem();
            TrainerMI = new ToolStripMenuItem();
            OutputMI = new ToolStripMenuItem();
            PurchaseMI = new ToolStripMenuItem();
            ReportsMI = new ToolStripMenuItem();
            MemberReportMI = new ToolStripMenuItem();
            TrainerReportMI = new ToolStripMenuItem();
            ExitMI = new ToolStripMenuItem();
            WelcomeL = new Label();
            HintL = new Label();
            MainMenuStrip1.SuspendLayout();
            SuspendLayout();
            //
            // MainMenuStrip1
            //
            MainMenuStrip1.Items.AddRange(new ToolStripItem[] { InputDataMI, OutputMI, ReportsMI, ExitMI });
            MainMenuStrip1.Location = new Point(0, 0);
            MainMenuStrip1.Name = "MainMenuStrip1";
            MainMenuStrip1.Size = new Size(640, 24);
            MainMenuStrip1.TabIndex = 0;
            MainMenuStrip1.Text = "menuStrip1";
            //
            // InputDataMI
            //
            InputDataMI.DropDownItems.AddRange(new ToolStripItem[] { MemberMI, TrainerMI });
            InputDataMI.Name = "InputDataMI";
            InputDataMI.Size = new Size(76, 20);
            InputDataMI.Text = "Input Data";
            //
            // MemberMI
            //
            MemberMI.Name = "MemberMI";
            MemberMI.Size = new Size(116, 22);
            MemberMI.Text = "Member";
            MemberMI.Click += MemberMI_Click;
            //
            // TrainerMI
            //
            TrainerMI.Name = "TrainerMI";
            TrainerMI.Size = new Size(116, 22);
            TrainerMI.Text = "Trainer";
            TrainerMI.Click += TrainerMI_Click;
            //
            // OutputMI
            //
            OutputMI.DropDownItems.AddRange(new ToolStripItem[] { PurchaseMI });
            OutputMI.Name = "OutputMI";
            OutputMI.Size = new Size(106, 20);
            OutputMI.Text = "Output Purchase";
            //
            // PurchaseMI
            //
            PurchaseMI.Name = "PurchaseMI";
            PurchaseMI.Size = new Size(190, 22);
            PurchaseMI.Text = "Purchase Sessions";
            PurchaseMI.Click += PurchaseMI_Click;
            //
            // ReportsMI
            //
            ReportsMI.DropDownItems.AddRange(new ToolStripItem[] { MemberReportMI, TrainerReportMI });
            ReportsMI.Name = "ReportsMI";
            ReportsMI.Size = new Size(59, 20);
            ReportsMI.Text = "Reports";
            //
            // MemberReportMI
            //
            MemberReportMI.Name = "MemberReportMI";
            MemberReportMI.Size = new Size(190, 22);
            MemberReportMI.Text = "Purchases per Member";
            MemberReportMI.Click += MemberReportMI_Click;
            //
            // TrainerReportMI
            //
            TrainerReportMI.Name = "TrainerReportMI";
            TrainerReportMI.Size = new Size(190, 22);
            TrainerReportMI.Text = "Sales per Trainer";
            TrainerReportMI.Click += TrainerReportMI_Click;
            //
            // ExitMI
            //
            ExitMI.Name = "ExitMI";
            ExitMI.Size = new Size(54, 20);
            ExitMI.Text = "Log Out";
            ExitMI.Click += ExitMI_Click;
            //
            // WelcomeL
            //
            WelcomeL.AutoSize = true;
            WelcomeL.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeL.Location = new Point(32, 80);
            WelcomeL.Name = "WelcomeL";
            WelcomeL.Size = new Size(120, 22);
            WelcomeL.TabIndex = 1;
            WelcomeL.Text = "Welcome";
            //
            // HintL
            //
            HintL.AutoSize = true;
            HintL.Location = new Point(34, 124);
            HintL.Name = "HintL";
            HintL.Size = new Size(300, 15);
            HintL.TabIndex = 2;
            HintL.Text = "Use the menu above to enter member and trainer data, record a purchase or open a report.";
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 260);
            Controls.Add(HintL);
            Controls.Add(WelcomeL);
            Controls.Add(MainMenuStrip1);
            MainMenuStrip = MainMenuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Workout Booking System";
            MainMenuStrip1.ResumeLayout(false);
            MainMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip1;
        private ToolStripMenuItem InputDataMI;
        private ToolStripMenuItem MemberMI;
        private ToolStripMenuItem TrainerMI;
        private ToolStripMenuItem OutputMI;
        private ToolStripMenuItem PurchaseMI;
        private ToolStripMenuItem ReportsMI;
        private ToolStripMenuItem MemberReportMI;
        private ToolStripMenuItem TrainerReportMI;
        private ToolStripMenuItem ExitMI;
        private Label WelcomeL;
        private Label HintL;
    }
}