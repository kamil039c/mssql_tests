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

namespace CRM_Tests
{
    public partial class fmGrid : Form
    {
        private int storedX;
        private int storedY;

        public fmGrid()
        {
            InitializeComponent();

            for (int i = 0; i < 16; i++)
            {
                this.GridTable.Columns.Add((i + 1).ToString(), (i + 1).ToString());
            }

            for (int i = 0; i < 16; i++)
            {
                this.GridTable.Rows.Add(new string[16]);
            }
        }

        private void GridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                LabelSelectInfo.Text = "x = " + e.RowIndex + ", " + "y = " + e.ColumnIndex;
                this.storedX = e.ColumnIndex + 1;
                this.storedY = e.RowIndex + 1;
            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Form1.DBCONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO prostokaty(x, y, kwadrat) VALUES(@x, @y, @kwadrat)", connection);
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@x", Value = this.storedX });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@y", Value = this.storedY });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@kwadrat", Value = this.storedX == this.storedY });
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                catch (SqlException excp)
                {
                    MessageBox.Show(this, excp.Message, "Błąd wykonania zapytania SQL!");
                }
            }

            this.Dispose();
        }
    }
}
