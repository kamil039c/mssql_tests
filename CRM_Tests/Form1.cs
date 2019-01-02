using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 *
 * DROP PROCEDURE usun_prostokat;
GO

CREATE PROCEDURE usun_prostokat   
    @id int    
AS   

    SET NOCOUNT ON;  
	DELETE FROM crm_test.dbo.prostokaty WHERE id = @id; 
GO  

EXECUTE usun_prostokat 19;
SELECT * FROM crm_test.dbo.prostokaty;
 **/


namespace CRM_Tests
{
    public partial class Form1 : Form
    {
        public const string DBCONNECTION_STRING = "Server=localhost;Database=crm_test;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (fmGrid form = new fmGrid())
            {
                form.ShowDialog();
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            GridVw.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(Form1.DBCONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT id, x, y, kwadrat FROM prostokaty", connection);
                    using (SqlDataReader rdr = cmd.ExecuteReader()) {
                        while (rdr.Read())
                        {
                            GridVw.Rows.Add(new string[] {
                                rdr.GetInt32(0).ToString(), rdr.GetInt32(1).ToString(), rdr.GetInt32(2).ToString(), rdr.GetBoolean(3).ToString()
                            });
                        }
                    }

                    connection.Close();
                }
                catch (SqlException excp)
                {
                    MessageBox.Show(this, excp.Message, "Błąd wykonania zapytania SQL!");
                }
            }
        }

        private void GridVw_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Form1.DBCONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    //SqlCommand cmd = new SqlCommand("DELETE FROM prostokaty WHERE id = @id", connection);
                    SqlCommand cmd = new SqlCommand("usun_prostokat", connection);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@id", Value = e.Row.Cells[0].Value.ToString() });
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch (SqlException excp)
                {
                    MessageBox.Show(this, excp.Message, "Błąd wykonania zapytania SQL!");
                }
            }
        }
    }
}
