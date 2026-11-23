namespace GymWorkoutFormProject
{
    partial class LoginTitle
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
            LoginTitleL = new Label();
            MembershipL = new Label();
            MembershipIDTB = new TextBox();
            PasswordL = new Label();
            PasswordTB = new TextBox();
            LoginB = new Button();
            SuspendLayout();
            // 
            // LoginTitleL
            // 
            LoginTitleL.AutoSize = true;
            LoginTitleL.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitleL.Location = new Point(111, 38);
            LoginTitleL.Name = "LoginTitleL";
            LoginTitleL.Size = new Size(603, 37);
            LoginTitleL.TabIndex = 0;
            LoginTitleL.Text = "Welcome to the Gym Workout System!";
            // 
            // MembershipL
            // 
            MembershipL.AutoSize = true;
            MembershipL.Location = new Point(193, 105);
            MembershipL.Name = "MembershipL";
            MembershipL.Size = new Size(149, 32);
            MembershipL.TabIndex = 1;
            MembershipL.Text = "Employee ID";
            // 
            // MembershipIDTB
            // 
            MembershipIDTB.Location = new Point(192, 139);
            MembershipIDTB.Name = "MembershipIDTB";
            MembershipIDTB.Size = new Size(428, 39);
            MembershipIDTB.TabIndex = 2;
            // 
            // PasswordL
            // 
            PasswordL.AutoSize = true;
            PasswordL.Location = new Point(192, 215);
            PasswordL.Name = "PasswordL";
            PasswordL.Size = new Size(111, 32);
            PasswordL.TabIndex = 3;
            PasswordL.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(192, 250);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(428, 39);
            PasswordTB.TabIndex = 4;
            // 
            // LoginB
            // 
            LoginB.Location = new Point(318, 323);
            LoginB.Name = "LoginB";
            LoginB.Size = new Size(185, 86);
            LoginB.TabIndex = 5;
            LoginB.Text = "Login";
            LoginB.UseVisualStyleBackColor = true;
            LoginB.Click += LoginB_Click;
            // 
            // LoginTitle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginB);
            Controls.Add(PasswordTB);
            Controls.Add(PasswordL);
            Controls.Add(MembershipIDTB);
            Controls.Add(MembershipL);
            Controls.Add(LoginTitleL);
            Name = "LoginTitle";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginTitleL;
        private Label MembershipL;
        private TextBox MembershipIDTB;
        private Label PasswordL;
        private TextBox PasswordTB;
        private Button LoginB;
    }
}
