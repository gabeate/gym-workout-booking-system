using Microsoft.Data.SqlClient;

namespace GymWorkoutFormProject
{
    public partial class LoginTitle : Form
    {
        public LoginTitle()
        {
            InitializeComponent();
            AcceptButton = LoginB;
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            int inputID;

            if (!int.TryParse(MembershipIDTB.Text.Trim(), out inputID) || inputID <= 0)
            {
                MessageBox.Show("Employee ID must be a whole number.");
                return;
            }

            // Connect to MS SQL
            // Open the connection.
            string connectionString = "Data Source=ASUSzenbook2;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Use SELECT with the ID and password
            string sql = "SELECT EmployeeName, Role FROM dbo.Employee " +
                "WHERE EmployeeId = @ParamEmployeeId AND Password = @ParamPassword";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ParamEmployeeId", inputID);
            command.Parameters.AddWithValue("@ParamPassword", PasswordTB.Text);

            SqlDataReader reader = command.ExecuteReader();

            bool found = false;
            string employeeName = "";
            string role = "";

            if (reader.Read())
            {
                found = true;
                employeeName = reader["EmployeeName"].ToString();
                role = reader["Role"].ToString();
            }

            reader.Close();

            // Close database.
            connection.Close();

            if (found)
            {
                MainForm mainForm = new MainForm(employeeName, role);

                mainForm.FormClosed += MainForm_FormClosed;

                Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID or Password.");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PasswordTB.Clear();
            Show();
        }
    }
}