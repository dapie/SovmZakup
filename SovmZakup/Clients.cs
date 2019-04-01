using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SovmZakup
{
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
            var connString = "Host=localhost;Port=5433;Username=postgres;Password=postgres;Database=sovmzak";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            string sql = "SELECT user_id, concat(first_name, ' ',last_name), login  FROM users";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            var ds = new DataSet();
            var dt = new DataTable();
            
            da.Fill(ds, "users");

            dt = ds.Tables[0];
            
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
