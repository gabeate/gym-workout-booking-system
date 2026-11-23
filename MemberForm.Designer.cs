namespace GymWorkoutFormProject
{
    partial class MemberForm
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
            MemIDL = new Label();
            MemIDTB = new TextBox();
            MemNameL = new Label();
            MemNameTB = new TextBox();
            PhoneL = new Label();
            PhoneTB = new TextBox();
            EmailL = new Label();
            EmailTB = new TextBox();
            PasswordL = new Label();
            PasswordTB = new TextBox();
            AddB = new Button();
            UpdateB = new Button();
            SearchB = new Button();
            DeleteB = new Button();
            ClearB = new Button();
            SuspendLayout();
            // 
            // MemIDL
            // 
            MemIDL.AutoSize = true;
            MemIDL.Location = new Point(45, 58);
            MemIDL.Margin = new Padding(6, 0, 6, 0);
            MemIDL.Name = "MemIDL";
            MemIDL.Size = new Size(135, 32);
            MemIDL.TabIndex = 0;
            MemIDL.Text = "Member ID";
            // 
            // MemIDTB
            // 
            MemIDTB.Location = new Point(279, 51);
            MemIDTB.Margin = new Padding(6, 6, 6, 6);
            MemIDTB.Name = "MemIDTB";
            MemIDTB.Size = new Size(815, 39);
            MemIDTB.TabIndex = 1;
            // 
            // MemNameL
            // 
            MemNameL.AutoSize = true;
            MemNameL.Location = new Point(45, 134);
            MemNameL.Margin = new Padding(6, 0, 6, 0);
            MemNameL.Name = "MemNameL";
            MemNameL.Size = new Size(78, 32);
            MemNameL.TabIndex = 2;
            MemNameL.Text = "Name";
            // 
            // MemNameTB
            // 
            MemNameTB.Location = new Point(279, 128);
            MemNameTB.Margin = new Padding(6, 6, 6, 6);
            MemNameTB.Name = "MemNameTB";
            MemNameTB.Size = new Size(815, 39);
            MemNameTB.TabIndex = 3;
            // 
            // PhoneL
            // 
            PhoneL.AutoSize = true;
            PhoneL.Location = new Point(45, 211);
            PhoneL.Margin = new Padding(6, 0, 6, 0);
            PhoneL.Name = "PhoneL";
            PhoneL.Size = new Size(177, 32);
            PhoneL.TabIndex = 4;
            PhoneL.Text = "Phone Number";
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(279, 205);
            PhoneTB.Margin = new Padding(6, 6, 6, 6);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(815, 39);
            PhoneTB.TabIndex = 5;
            // 
            // EmailL
            // 
            EmailL.AutoSize = true;
            EmailL.Location = new Point(45, 288);
            EmailL.Margin = new Padding(6, 0, 6, 0);
            EmailL.Name = "EmailL";
            EmailL.Size = new Size(172, 32);
            EmailL.TabIndex = 6;
            EmailL.Text = "E-mail Address";
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(279, 282);
            EmailTB.Margin = new Padding(6, 6, 6, 6);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(815, 39);
            EmailTB.TabIndex = 7;
            // 
            // PasswordL
            // 
            PasswordL.AutoSize = true;
            PasswordL.Location = new Point(45, 365);
            PasswordL.Margin = new Padding(6, 0, 6, 0);
            PasswordL.Name = "PasswordL";
            PasswordL.Size = new Size(111, 32);
            PasswordL.TabIndex = 8;
            PasswordL.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(279, 358);
            PasswordTB.Margin = new Padding(6, 6, 6, 6);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(815, 39);
            PasswordTB.TabIndex = 9;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // AddB
            // 
            AddB.Location = new Point(45, 457);
            AddB.Margin = new Padding(6, 6, 6, 6);
            AddB.Name = "AddB";
            AddB.Size = new Size(195, 79);
            AddB.TabIndex = 10;
            AddB.Text = "Add Member";
            AddB.UseVisualStyleBackColor = true;
            AddB.Click += AddB_Click;
            // 
            // UpdateB
            // 
            UpdateB.Location = new Point(258, 457);
            UpdateB.Margin = new Padding(6, 6, 6, 6);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(195, 79);
            UpdateB.TabIndex = 11;
            UpdateB.Text = "Update Member";
            UpdateB.UseVisualStyleBackColor = true;
            UpdateB.Click += UpdateB_Click;
            // 
            // SearchB
            // 
            SearchB.Location = new Point(472, 457);
            SearchB.Margin = new Padding(6, 6, 6, 6);
            SearchB.Name = "SearchB";
            SearchB.Size = new Size(195, 79);
            SearchB.TabIndex = 12;
            SearchB.Text = "Search Member";
            SearchB.UseVisualStyleBackColor = true;
            SearchB.Click += SearchB_Click;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(685, 457);
            DeleteB.Margin = new Padding(6, 6, 6, 6);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(195, 79);
            DeleteB.TabIndex = 13;
            DeleteB.Text = "Delete Member";
            DeleteB.UseVisualStyleBackColor = true;
            DeleteB.Click += DeleteB_Click;
            // 
            // ClearB
            // 
            ClearB.Location = new Point(899, 457);
            ClearB.Margin = new Padding(6, 6, 6, 6);
            ClearB.Name = "ClearB";
            ClearB.Size = new Size(195, 79);
            ClearB.TabIndex = 14;
            ClearB.Text = "Clear";
            ClearB.UseVisualStyleBackColor = true;
            ClearB.Click += ClearB_Click;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 576);
            Controls.Add(ClearB);
            Controls.Add(DeleteB);
            Controls.Add(SearchB);
            Controls.Add(UpdateB);
            Controls.Add(AddB);
            Controls.Add(PasswordTB);
            Controls.Add(PasswordL);
            Controls.Add(EmailTB);
            Controls.Add(EmailL);
            Controls.Add(PhoneTB);
            Controls.Add(PhoneL);
            Controls.Add(MemNameTB);
            Controls.Add(MemNameL);
            Controls.Add(MemIDTB);
            Controls.Add(MemIDL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            Name = "MemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MemIDL;
        private TextBox MemIDTB;
        private Label MemNameL;
        private TextBox MemNameTB;
        private Label PhoneL;
        private TextBox PhoneTB;
        private Label EmailL;
        private TextBox EmailTB;
        private Label PasswordL;
        private TextBox PasswordTB;
        private Button AddB;
        private Button UpdateB;
        private Button SearchB;
        private Button DeleteB;
        private Button ClearB;
    }
}