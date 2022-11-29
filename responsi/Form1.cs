using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace responsi
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            string connstring = "Host= localhost; Port=5432; Username= postgres; Password= Informatika; Database= responsiAkb";
            conn = new NpgsqlConnection(connstring);
            //NpgsqlCommand cmd = new NpgsqlCommand();
            conn.Open();
            string sql = "select * from st_insert()";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable dtKaryawan = new DataTable();
            dtKaryawan.Load(reader);
            dgvKaryawan.DataSource = dtKaryawan;


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
