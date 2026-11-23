namespace GymWorkoutFormProject
{
    partial class TrainerReportForm
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
            TitleL = new Label();
            ReportLB = new ListBox();
            CloseB = new Button();
            SuspendLayout();
            // 
            // TitleL
            // 
            TitleL.AutoSize = true;
            TitleL.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleL.Location = new Point(20, 15);
            TitleL.Name = "TitleL";
            TitleL.Size = new Size(190, 22);
            TitleL.TabIndex = 0;
            TitleL.Text = "Sales per Trainer";
            // 
            // ReportLB
            // 
            ReportLB.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReportLB.FormattingEnabled = true;
            ReportLB.ItemHeight = 16;
            ReportLB.Location = new Point(20, 55);
            ReportLB.Name = "ReportLB";
            ReportLB.Size = new Size(740, 292);
            ReportLB.TabIndex = 1;
            // 
            // CloseB
            // 
            CloseB.Location = new Point(660, 365);
            CloseB.Name = "CloseB";
            CloseB.Size = new Size(100, 32);
            CloseB.TabIndex = 2;
            CloseB.Text = "Close";
            CloseB.UseVisualStyleBackColor = true;
            CloseB.Click += CloseB_Click;
            // 
            // TrainerReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 415);
            Controls.Add(CloseB);
            Controls.Add(ReportLB);
            Controls.Add(TitleL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrainerReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report - Sales per Trainer";
            Load += TrainerReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleL;
        private ListBox ReportLB;
        private Button CloseB;
    }
}