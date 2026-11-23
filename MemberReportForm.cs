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
    public partial class MemberReportForm : Form
    {
        public MemberReportForm()
        {
            InitializeComponent();
        }

        private void MemberReportForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=[YOUR SERVER NAME];Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT m.MemberId, m.MemberName, " +
                "COUNT(p.PurchaseId) AS NumPurchases, " +
                "ISNULL(SUM(p.NumSession), 0) AS NumSessions, " +
                "ISNULL(SUM(p.Total), 0) AS TotalSpent " +
                "FROM dbo.Member m LEFT JOIN dbo.Purchase p ON m.MemberId = p.MemberId " +
                "GROUP BY m.MemberId, m.MemberName " +
                "ORDER BY m.MemberId";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            ReportLB.Items.Add("ID".PadRight(8) + "Member".PadRight(22)
                + "Purchases".PadLeft(11) + "Sessions".PadLeft(10) + "Total Spent".PadLeft(15));
            ReportLB.Items.Add(new string('-', 66));

            int sumPurchases = 0;
            int sumSessions = 0;
            double sumSpent = 0;

            while (reader.Read())
            {
                int purchases = int.Parse(reader["NumPurchases"].ToString());
                int sessions = int.Parse(reader["NumSessions"].ToString());
                double spent = double.Parse(reader["TotalSpent"].ToString());

                ReportLB.Items.Add(reader["MemberId"].ToString().PadRight(8)
                    + reader["MemberName"].ToString().PadRight(22)
                    + purchases.ToString().PadLeft(11)
                    + sessions.ToString().PadLeft(10)
                    + ("$" + spent.ToString("N2")).PadLeft(15));

                sumPurchases = sumPurchases + purchases;
                sumSessions = sumSessions + sessions;
                sumSpent = sumSpent + spent;
            }

            reader.Close();

            // Close database.
            connection.Close();

            ReportLB.Items.Add(new string('-', 66));
            ReportLB.Items.Add("TOTAL".PadRight(30)
                + sumPurchases.ToString().PadLeft(11)
                + sumSessions.ToString().PadLeft(10)
                + ("$" + sumSpent.ToString("N2")).PadLeft(15));
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
