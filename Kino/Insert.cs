using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kino
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }
        static string connect = "Server=localhost;Database=new_schema;User=root;Password=root";
        MySqlConnection conn = new MySqlConnection(connect);
        private void Insert_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("show columns from " + Application.OpenForms[0].Controls["label1"].Text, conn);
            DbDataReader dbr = cmd.ExecuteReader();
            while (dbr.Read()) 
            {
                DataGridViewTextBoxColumn dgtb = new DataGridViewTextBoxColumn();
                dgtb.Name = dbr.GetString(0);
                dataGridView1.Columns.Add(dgtb);
            }
            dataGridView1.Rows.Add();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string table = Application.OpenForms[0].Controls["label1"].Text;
            MySqlCommand cmd = new MySqlCommand("show columns from " + table, conn);
            DbDataReader dbr = cmd.ExecuteReader();
            int i = 0;
            string sql = "INSERT INTO " + table + " Values(";
            while (dbr.Read())
            {
                if (dbr.GetString(1).Contains("int") || dbr.GetString(1).Contains("decimal")) 
                {
                    sql += dataGridView1.Rows[0].Cells[i].Value.ToString() + ", ";
                }
                else 
                {
                    sql += "'" + dataGridView1.Rows[0].Cells[i].Value.ToString() + "', ";
                }
                i++;
            }
            conn.Close();
            conn.Open();
            sql = sql.Substring(0, sql.Length-2);
            sql += ");";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
