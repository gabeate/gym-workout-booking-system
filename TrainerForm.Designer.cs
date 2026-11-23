namespace GymWorkoutFormProject
{
    partial class TrainerForm
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
            TrIDL = new Label();
            TrIDTB = new TextBox();
            TrNameL = new Label();
            TrNameTB = new TextBox();
            TrExpertiseL = new Label();
            TrExpertiseTB = new TextBox();
            TrRateL = new Label();
            TrRateTB = new TextBox();
            AddB = new Button();
            UpdateB = new Button();
            SearchB = new Button();
            DeleteB = new Button();
            ClearB = new Button();
            SuspendLayout();
            // 
            // TrIDL
            // 
            TrIDL.AutoSize = true;
            TrIDL.Location = new Point(45, 58);
            TrIDL.Margin = new Padding(6, 0, 6, 0);
            TrIDL.Name = "TrIDL";
            TrIDL.Size = new Size(116, 32);
            TrIDL.TabIndex = 0;
            TrIDL.Text = "Trainer ID";
            // 
            // TrIDTB
            // 
            TrIDTB.Location = new Point(279, 51);
            TrIDTB.Margin = new Padding(6, 6, 6, 6);
            TrIDTB.Name = "TrIDTB";
            TrIDTB.Size = new Size(815, 39);
            TrIDTB.TabIndex = 1;
            // 
            // TrNameL
            // 
            TrNameL.AutoSize = true;
            TrNameL.Location = new Point(45, 134);
            TrNameL.Margin = new Padding(6, 0, 6, 0);
            TrNameL.Name = "TrNameL";
            TrNameL.Size = new Size(78, 32);
            TrNameL.TabIndex = 2;
            TrNameL.Text = "Name";
            // 
            // TrNameTB
            // 
            TrNameTB.Location = new Point(279, 128);
            TrNameTB.Margin = new Padding(6, 6, 6, 6);
            TrNameTB.Name = "TrNameTB";
            TrNameTB.Size = new Size(815, 39);
            TrNameTB.TabIndex = 3;
            // 
            // TrExpertiseL
            // 
            TrExpertiseL.AutoSize = true;
            TrExpertiseL.Location = new Point(45, 211);
            TrExpertiseL.Margin = new Padding(6, 0, 6, 0);
            TrExpertiseL.Name = "TrExpertiseL";
            TrExpertiseL.Size = new Size(109, 32);
            TrExpertiseL.TabIndex = 4;
            TrExpertiseL.Text = "Expertise";
            // 
            // TrExpertiseTB
            // 
            TrExpertiseTB.Location = new Point(279, 205);
            TrExpertiseTB.Margin = new Padding(6, 6, 6, 6);
            TrExpertiseTB.Name = "TrExpertiseTB";
            TrExpertiseTB.Size = new Size(815, 39);
            TrExpertiseTB.TabIndex = 5;
            // 
            // TrRateL
            // 
            TrRateL.AutoSize = true;
            TrRateL.Location = new Point(45, 288);
            TrRateL.Margin = new Padding(6, 0, 6, 0);
            TrRateL.Name = "TrRateL";
            TrRateL.Size = new Size(173, 32);
            TrRateL.TabIndex = 6;
            TrRateL.Text = "Hourly Rate ($)";
            // 
            // TrRateTB
            // 
            TrRateTB.Location = new Point(279, 282);
            TrRateTB.Margin = new Padding(6, 6, 6, 6);
            TrRateTB.Name = "TrRateTB";
            TrRateTB.Size = new Size(815, 39);
            TrRateTB.TabIndex = 7;
            // 
            // AddB
            // 
            AddB.Location = new Point(45, 405);
            AddB.Margin = new Padding(6, 6, 6, 6);
            AddB.Name = "AddB";
            AddB.Size = new Size(195, 68);
            AddB.TabIndex = 8;
            AddB.Text = "Add Trainer";
            AddB.UseVisualStyleBackColor = true;
            AddB.Click += AddB_Click;
            // 
            // UpdateB
            // 
            UpdateB.Location = new Point(258, 405);
            UpdateB.Margin = new Padding(6, 6, 6, 6);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(195, 68);
            UpdateB.TabIndex = 9;
            UpdateB.Text = "Update Trainer";
            UpdateB.UseVisualStyleBackColor = true;
            UpdateB.Click += UpdateB_Click;
            // 
            // SearchB
            // 
            SearchB.Location = new Point(472, 405);
            SearchB.Margin = new Padding(6, 6, 6, 6);
            SearchB.Name = "SearchB";
            SearchB.Size = new Size(195, 68);
            SearchB.TabIndex = 10;
            SearchB.Text = "Search Trainer";
            SearchB.UseVisualStyleBackColor = true;
            SearchB.Click += SearchB_Click;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(685, 405);
            DeleteB.Margin = new Padding(6, 6, 6, 6);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(195, 68);
            DeleteB.TabIndex = 11;
            DeleteB.Text = "Delete Trainer";
            DeleteB.UseVisualStyleBackColor = true;
            DeleteB.Click += DeleteB_Click;
            // 
            // ClearB
            // 
            ClearB.Location = new Point(899, 405);
            ClearB.Margin = new Padding(6, 6, 6, 6);
            ClearB.Name = "ClearB";
            ClearB.Size = new Size(195, 68);
            ClearB.TabIndex = 12;
            ClearB.Text = "Clear";
            ClearB.UseVisualStyleBackColor = true;
            ClearB.Click += ClearB_Click;
            // 
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 533);
            Controls.Add(ClearB);
            Controls.Add(DeleteB);
            Controls.Add(SearchB);
            Controls.Add(UpdateB);
            Controls.Add(AddB);
            Controls.Add(TrRateTB);
            Controls.Add(TrRateL);
            Controls.Add(TrExpertiseTB);
            Controls.Add(TrExpertiseL);
            Controls.Add(TrNameTB);
            Controls.Add(TrNameL);
            Controls.Add(TrIDTB);
            Controls.Add(TrIDL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            Name = "TrainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trainer Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TrIDL;
        private TextBox TrIDTB;
        private Label TrNameL;
        private TextBox TrNameTB;
        private Label TrExpertiseL;
        private TextBox TrExpertiseTB;
        private Label TrRateL;
        private TextBox TrRateTB;
        private Button AddB;
        private Button UpdateB;
        private Button SearchB;
        private Button DeleteB;
        private Button ClearB;
    }
}