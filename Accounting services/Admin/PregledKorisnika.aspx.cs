using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Skola.Admin
{
    public partial class UbacivanjeUcenika : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=ALEKSA\\ALEKSASQL;Initial Catalog=Accounting;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            PrikazKlijenata(con);
            con.Close();
        }

        void PrikazKlijenata(SqlConnection con)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    string query = "SELECT * " +
                                   "FROM Klijent ";

                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gridView1.DataSource = dt;
                    gridView1.DataBind();
                }

            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                System.Diagnostics.Debug.WriteLine("Exception Message: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }
    }
}
