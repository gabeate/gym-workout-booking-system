namespace GymWorkoutFormProject
{
    partial class SessionsForm
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
            label1 = new Label();
            PurchSessionRTB = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 0;
            label1.Text = "Sessions Purchased:";
            // 
            // PurchSessionRTB
            // 
            PurchSessionRTB.Location = new Point(44, 91);
            PurchSessionRTB.Name = "PurchSessionRTB";
            PurchSessionRTB.Size = new Size(710, 309);
            PurchSessionRTB.TabIndex = 1;
            PurchSessionRTB.Text = "";
            // 
            // SessionsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PurchSessionRTB);
            Controls.Add(label1);
            Name = "SessionsForm";
            Text = "My Sessions";
            Load += SessionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox PurchSessionRTB;
    }
}