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
        private string connstring = "Host= localhost; Port=2022; Username= postgres; Password= informatika; Database= responsiAkb";
        NpgsqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            
            conn = new NpgsqlConnection(connstring);
            //NpgsqlCommand cmd = new NpgsqlCommand();
            conn.Open();
            string sql = "select * from st_insertKar()";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable dtKaryawan = new DataTable();
            dtKaryawan.Load(reader);
            dgvKaryawan.DataSource = dtKaryawan;


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            string sql = @"select * from st_insertKar(:_nama, :_id_dep)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("_name", tbNama );
            cmd.Parameters.AddWithValue("_id_dep", tbDep);

            if((int) cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Insert Berhasil")
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
