namespace GymWorkoutFormProject
{
    partial class PurchaseForm
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
            MemberHeadL = new Label();
            MemIDL = new Label();
            MemIDTB = new TextBox();
            SearchMemberB = new Button();
            MemNameL = new Label();
            MemNameTB = new TextBox();
            MemEmailL = new Label();
            MemEmailTB = new TextBox();
            TrainerHeadL = new Label();
            TrIDL = new Label();
            TrIDTB = new TextBox();
            SearchTrainerB = new Button();
            TrNameL = new Label();
            TrNameTB = new TextBox();
            TrYearsL = new Label();
            TrYearsTB = new TextBox();
            TrRateL = new Label();
            TrRateTB = new TextBox();
            PurchaseHeadL = new Label();
            SessionsL = new Label();
            SessionsTB = new TextBox();
            MonthL = new Label();
            MonthCB = new ComboBox();
            YearL = new Label();
            YearTB = new TextBox();
            AmountHeadL = new Label();
            SubtotalL = new Label();
            SubtotalTB = new TextBox();
            ProvTaxL = new Label();
            ProvTaxTB = new TextBox();
            FedTaxL = new Label();
            FedTaxTB = new TextBox();
            TotalL = new Label();
            TotalTB = new TextBox();
            CalculateB = new Button();
            ConfirmB = new Button();
            ResetB = new Button();
            SuspendLayout();
            // 
            // MemberHeadL
            // 
            MemberHeadL.AutoSize = true;
            MemberHeadL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberHeadL.Location = new Point(24, 16);
            MemberHeadL.Name = "MemberHeadL";
            MemberHeadL.Size = new Size(80, 20);
            MemberHeadL.TabIndex = 0;
            MemberHeadL.Text = "Member";
            // 
            // MemIDL
            // 
            MemIDL.AutoSize = true;
            MemIDL.Location = new Point(24, 47);
            MemIDL.Name = "MemIDL";
            MemIDL.Size = new Size(80, 20);
            MemIDL.TabIndex = 1;
            MemIDL.Text = "Member ID";
            // 
            // MemIDTB
            // 
            MemIDTB.Location = new Point(150, 44);
            MemIDTB.Name = "MemIDTB";
            MemIDTB.Size = new Size(170, 23);
            MemIDTB.TabIndex = 2;
            MemIDTB.TextChanged += Input_Changed;
            // 
            // SearchMemberB
            // 
            SearchMemberB.Location = new Point(330, 42);
            SearchMemberB.Name = "SearchMemberB";
            SearchMemberB.Size = new Size(110, 27);
            SearchMemberB.TabIndex = 3;
            SearchMemberB.Text = "Search Member";
            SearchMemberB.UseVisualStyleBackColor = true;
            SearchMemberB.Click += SearchMemberB_Click;
            // 
            // MemNameL
            // 
            MemNameL.AutoSize = true;
            MemNameL.Location = new Point(24, 81);
            MemNameL.Name = "MemNameL";
            MemNameL.Size = new Size(80, 20);
            MemNameL.TabIndex = 4;
            MemNameL.Text = "Name";
            // 
            // MemNameTB
            // 
            MemNameTB.Location = new Point(150, 78);
            MemNameTB.Name = "MemNameTB";
            MemNameTB.ReadOnly = true;
            MemNameTB.Size = new Size(290, 23);
            MemNameTB.TabIndex = 5;
            // 
            // MemEmailL
            // 
            MemEmailL.AutoSize = true;
            MemEmailL.Location = new Point(24, 115);
            MemEmailL.Name = "MemEmailL";
            MemEmailL.Size = new Size(80, 20);
            MemEmailL.TabIndex = 6;
            MemEmailL.Text = "E-mail";
            // 
            // MemEmailTB
            // 
            MemEmailTB.Location = new Point(150, 112);
            MemEmailTB.Name = "MemEmailTB";
            MemEmailTB.ReadOnly = true;
            MemEmailTB.Size = new Size(290, 23);
            MemEmailTB.TabIndex = 7;
            // 
            // TrainerHeadL
            // 
            TrainerHeadL.AutoSize = true;
            TrainerHeadL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TrainerHeadL.Location = new Point(24, 156);
            TrainerHeadL.Name = "TrainerHeadL";
            TrainerHeadL.Size = new Size(80, 20);
            TrainerHeadL.TabIndex = 8;
            TrainerHeadL.Text = "Trainer";
            // 
            // TrIDL
            // 
            TrIDL.AutoSize = true;
            TrIDL.Location = new Point(24, 187);
            TrIDL.Name = "TrIDL";
            TrIDL.Size = new Size(80, 20);
            TrIDL.TabIndex = 9;
            TrIDL.Text = "Trainer ID";
            // 
            // TrIDTB
            // 
            TrIDTB.Location = new Point(150, 184);
            TrIDTB.Name = "TrIDTB";
            TrIDTB.Size = new Size(170, 23);
            TrIDTB.TabIndex = 10;
            TrIDTB.TextChanged += Input_Changed;
            // 
            // SearchTrainerB
            // 
            SearchTrainerB.Location = new Point(330, 182);
            SearchTrainerB.Name = "SearchTrainerB";
            SearchTrainerB.Size = new Size(110, 27);
            SearchTrainerB.TabIndex = 11;
            SearchTrainerB.Text = "Search Trainer";
            SearchTrainerB.UseVisualStyleBackColor = true;
            SearchTrainerB.Click += SearchTrainerB_Click;
            // 
            // TrNameL
            // 
            TrNameL.AutoSize = true;
            TrNameL.Location = new Point(24, 221);
            TrNameL.Name = "TrNameL";
            TrNameL.Size = new Size(80, 20);
            TrNameL.TabIndex = 12;
            TrNameL.Text = "Name";
            // 
            // TrNameTB
            // 
            TrNameTB.Location = new Point(150, 218);
            TrNameTB.Name = "TrNameTB";
            TrNameTB.ReadOnly = true;
            TrNameTB.Size = new Size(290, 23);
            TrNameTB.TabIndex = 13;
            // 
            // TrYearsL
            // 
            TrYearsL.AutoSize = true;
            TrYearsL.Location = new Point(24, 255);
            TrYearsL.Name = "TrYearsL";
            TrYearsL.Size = new Size(80, 20);
            TrYearsL.TabIndex = 14;
            TrYearsL.Text = "Expertise";
            // 
            // TrYearsTB
            // 
            TrYearsTB.Location = new Point(150, 252);
            TrYearsTB.Name = "TrYearsTB";
            TrYearsTB.ReadOnly = true;
            TrYearsTB.Size = new Size(290, 23);
            TrYearsTB.TabIndex = 15;
            // 
            // TrRateL
            // 
            TrRateL.AutoSize = true;
            TrRateL.Location = new Point(24, 289);
            TrRateL.Name = "TrRateL";
            TrRateL.Size = new Size(80, 20);
            TrRateL.TabIndex = 16;
            TrRateL.Text = "Hourly Rate";
            // 
            // TrRateTB
            // 
            TrRateTB.Location = new Point(150, 286);
            TrRateTB.Name = "TrRateTB";
            TrRateTB.ReadOnly = true;
            TrRateTB.Size = new Size(290, 23);
            TrRateTB.TabIndex = 17;
            // 
            // PurchaseHeadL
            // 
            PurchaseHeadL.AutoSize = true;
            PurchaseHeadL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PurchaseHeadL.Location = new Point(480, 16);
            PurchaseHeadL.Name = "PurchaseHeadL";
            PurchaseHeadL.Size = new Size(80, 20);
            PurchaseHeadL.TabIndex = 18;
            PurchaseHeadL.Text = "Purchase";
            // 
            // SessionsL
            // 
            SessionsL.AutoSize = true;
            SessionsL.Location = new Point(480, 47);
            SessionsL.Name = "SessionsL";
            SessionsL.Size = new Size(80, 20);
            SessionsL.TabIndex = 19;
            SessionsL.Text = "1-hour sessions";
            // 
            // SessionsTB
            // 
            SessionsTB.Location = new Point(600, 44);
            SessionsTB.Name = "SessionsTB";
            SessionsTB.Size = new Size(130, 23);
            SessionsTB.TabIndex = 20;
            SessionsTB.TextChanged += Input_Changed;
            // 
            // MonthL
            // 
            MonthL.AutoSize = true;
            MonthL.Location = new Point(480, 81);
            MonthL.Name = "MonthL";
            MonthL.Size = new Size(80, 20);
            MonthL.TabIndex = 21;
            MonthL.Text = "Month";
            // 
            // MonthCB
            // 
            MonthCB.Location = new Point(600, 78);
            MonthCB.Name = "MonthCB";
            MonthCB.DropDownStyle = ComboBoxStyle.DropDownList;
            MonthCB.FormattingEnabled = true;
            MonthCB.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            MonthCB.Size = new Size(130, 23);
            MonthCB.TabIndex = 22;
            MonthCB.SelectedIndexChanged += Input_Changed;
            // 
            // YearL
            // 
            YearL.AutoSize = true;
            YearL.Location = new Point(480, 115);
            YearL.Name = "YearL";
            YearL.Size = new Size(80, 20);
            YearL.TabIndex = 23;
            YearL.Text = "Year";
            // 
            // YearTB
            // 
            YearTB.Location = new Point(600, 112);
            YearTB.Name = "YearTB";
            YearTB.MaxLength = 4;
            YearTB.Size = new Size(130, 23);
            YearTB.TabIndex = 24;
            YearTB.TextChanged += Input_Changed;
            // 
            // AmountHeadL
            // 
            AmountHeadL.AutoSize = true;
            AmountHeadL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmountHeadL.Location = new Point(480, 156);
            AmountHeadL.Name = "AmountHeadL";
            AmountHeadL.Size = new Size(80, 20);
            AmountHeadL.TabIndex = 25;
            AmountHeadL.Text = "Amount";
            // 
            // SubtotalL
            // 
            SubtotalL.AutoSize = true;
            SubtotalL.Location = new Point(480, 187);
            SubtotalL.Name = "SubtotalL";
            SubtotalL.Size = new Size(80, 20);
            SubtotalL.TabIndex = 26;
            SubtotalL.Text = "Subtotal";
            // 
            // SubtotalTB
            // 
            SubtotalTB.Location = new Point(600, 184);
            SubtotalTB.Name = "SubtotalTB";
            SubtotalTB.ReadOnly = true;
            SubtotalTB.Size = new Size(130, 23);
            SubtotalTB.TabIndex = 27;
            // 
            // ProvTaxL
            // 
            ProvTaxL.AutoSize = true;
            ProvTaxL.Location = new Point(480, 221);
            ProvTaxL.Name = "ProvTaxL";
            ProvTaxL.Size = new Size(80, 20);
            ProvTaxL.TabIndex = 28;
            ProvTaxL.Text = "Prov. Tax (9.975%)";
            // 
            // ProvTaxTB
            // 
            ProvTaxTB.Location = new Point(600, 218);
            ProvTaxTB.Name = "ProvTaxTB";
            ProvTaxTB.ReadOnly = true;
            ProvTaxTB.Size = new Size(130, 23);
            ProvTaxTB.TabIndex = 29;
            // 
            // FedTaxL
            // 
            FedTaxL.AutoSize = true;
            FedTaxL.Location = new Point(480, 255);
            FedTaxL.Name = "FedTaxL";
            FedTaxL.Size = new Size(80, 20);
            FedTaxL.TabIndex = 30;
            FedTaxL.Text = "Fed. Tax (5%)";
            // 
            // FedTaxTB
            // 
            FedTaxTB.Location = new Point(600, 252);
            FedTaxTB.Name = "FedTaxTB";
            FedTaxTB.ReadOnly = true;
            FedTaxTB.Size = new Size(130, 23);
            FedTaxTB.TabIndex = 31;
            // 
            // TotalL
            // 
            TotalL.AutoSize = true;
            TotalL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalL.Location = new Point(480, 289);
            TotalL.Name = "TotalL";
            TotalL.Size = new Size(80, 20);
            TotalL.TabIndex = 32;
            TotalL.Text = "TOTAL";
            // 
            // TotalTB
            // 
            TotalTB.Location = new Point(600, 286);
            TotalTB.Name = "TotalTB";
            TotalTB.ReadOnly = true;
            TotalTB.Size = new Size(130, 23);
            TotalTB.TabIndex = 33;
            // 
            // CalculateB
            // 
            CalculateB.Location = new Point(150, 350);
            CalculateB.Name = "CalculateB";
            CalculateB.Size = new Size(130, 36);
            CalculateB.TabIndex = 34;
            CalculateB.Text = "Calculate";
            CalculateB.UseVisualStyleBackColor = true;
            CalculateB.Click += CalculateB_Click;
            // 
            // ConfirmB
            // 
            ConfirmB.Location = new Point(295, 350);
            ConfirmB.Name = "ConfirmB";
            ConfirmB.Size = new Size(130, 36);
            ConfirmB.TabIndex = 35;
            ConfirmB.Text = "Confirm Purchase";
            ConfirmB.UseVisualStyleBackColor = true;
            ConfirmB.Click += ConfirmB_Click;
            // 
            // ResetB
            // 
            ResetB.Location = new Point(440, 350);
            ResetB.Name = "ResetB";
            ResetB.Size = new Size(130, 36);
            ResetB.TabIndex = 36;
            ResetB.Text = "Reset";
            ResetB.UseVisualStyleBackColor = true;
            ResetB.Click += ResetB_Click;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 410);
            Controls.Add(ResetB);
            Controls.Add(ConfirmB);
            Controls.Add(CalculateB);
            Controls.Add(TotalTB);
            Controls.Add(TotalL);
            Controls.Add(FedTaxTB);
            Controls.Add(FedTaxL);
            Controls.Add(ProvTaxTB);
            Controls.Add(ProvTaxL);
            Controls.Add(SubtotalTB);
            Controls.Add(SubtotalL);
            Controls.Add(AmountHeadL);
            Controls.Add(YearTB);
            Controls.Add(YearL);
            Controls.Add(MonthCB);
            Controls.Add(MonthL);
            Controls.Add(SessionsTB);
            Controls.Add(SessionsL);
            Controls.Add(PurchaseHeadL);
            Controls.Add(TrRateTB);
            Controls.Add(TrRateL);
            Controls.Add(TrYearsTB);
            Controls.Add(TrYearsL);
            Controls.Add(TrNameTB);
            Controls.Add(TrNameL);
            Controls.Add(SearchTrainerB);
            Controls.Add(TrIDTB);
            Controls.Add(TrIDL);
            Controls.Add(TrainerHeadL);
            Controls.Add(MemEmailTB);
            Controls.Add(MemEmailL);
            Controls.Add(MemNameTB);
            Controls.Add(MemNameL);
            Controls.Add(SearchMemberB);
            Controls.Add(MemIDTB);
            Controls.Add(MemIDL);
            Controls.Add(MemberHeadL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Sessions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MemberHeadL;
        private Label MemIDL;
        private TextBox MemIDTB;
        private Button SearchMemberB;
        private Label MemNameL;
        private TextBox MemNameTB;
        private Label MemEmailL;
        private TextBox MemEmailTB;
        private Label TrainerHeadL;
        private Label TrIDL;
        private TextBox TrIDTB;
        private Button SearchTrainerB;
        private Label TrNameL;
        private TextBox TrNameTB;
        private Label TrYearsL;
        private TextBox TrYearsTB;
        private Label TrRateL;
        private TextBox TrRateTB;
        private Label PurchaseHeadL;
        private Label SessionsL;
        private TextBox SessionsTB;
        private Label MonthL;
        private ComboBox MonthCB;
        private Label YearL;
        private TextBox YearTB;
        private Label AmountHeadL;
        private Label SubtotalL;
        private TextBox SubtotalTB;
        private Label ProvTaxL;
        private TextBox ProvTaxTB;
        private Label FedTaxL;
        private TextBox FedTaxTB;
        private Label TotalL;
        private TextBox TotalTB;
        private Button CalculateB;
        private Button ConfirmB;
        private Button ResetB;
    }
}
