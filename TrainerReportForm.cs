using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymWorkoutFormProject
{
    public partial class TrainerReportForm : Form
    {
        public TrainerReportForm()
        {
            InitializeComponent();
        }

        private void TrainerReportForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ASUSzenbook2;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT t.TrainerId, t.TrainerName, t.Expertise, " +
                "COUNT(p.PurchaseId) AS NumPurchases, " +
                "ISNULL(SUM(p.NumSession), 0) AS NumSessions, " +
                "ISNULL(SUM(p.Total), 0) AS TotalSales " +
                "FROM dbo.Trainer t LEFT JOIN dbo.Purchase p ON t.TrainerId = p.TrainerId " +
                "GROUP BY t.TrainerId, t.TrainerName, t.Expertise " +
                "ORDER BY t.TrainerId";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            ReportLB.Items.Add("ID".PadRight(6) + "Trainer".PadRight(18) + "Expertise".PadRight(16)
                + "Purchases".PadLeft(11) + "Sessions".PadLeft(10) + "Total Sales".PadLeft(15));
            ReportLB.Items.Add(new string('-', 76));

            int sumPurchases = 0;
            int sumSessions = 0;
            double sumSales = 0;

            while (reader.Read())
            {
                int purchases = int.Parse(reader["NumPurchases"].ToString());
                int sessions = int.Parse(reader["NumSessions"].ToString());
                double sales = double.Parse(reader["TotalSales"].ToString());

                ReportLB.Items.Add(reader["TrainerId"].ToString().PadRight(6)
                    + reader["TrainerName"].ToString().PadRight(18)
                    + reader["Expertise"].ToString().PadRight(16)
                    + purchases.ToString().PadLeft(11)
                    + sessions.ToString().PadLeft(10)
                    + ("$" + sales.ToString("N2")).PadLeft(15));

                sumPurchases = sumPurchases + purchases;
                sumSessions = sumSessions + sessions;
                sumSales = sumSales + sales;
            }

            reader.Close();

            // Close database.
            connection.Close();

            ReportLB.Items.Add(new string('-', 76));
            ReportLB.Items.Add("TOTAL".PadRight(40)
                + sumPurchases.ToString().PadLeft(11)
                + sumSessions.ToString().PadLeft(10)
                + ("$" + sumSales.ToString("N2")).PadLeft(15));
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}