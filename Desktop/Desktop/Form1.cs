using MySql.Data.MySqlClient;
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

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getKolcsonzok("datasource=localhost;port=3306;Initial Catalog='konyvtar';username=root;password=");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getKolcsonzok(string con)
        {
            MySqlConnection mysqlCon = new

            MySqlConnection(con);
            mysqlCon.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT nev,id FROM kolcsonzok;";
            adapter.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            kolcsonzokBox.DataSource = bSource;
            kolcsonzokBox.DisplayMember = "nev";
            kolcsonzokBox.ValueMember = "id";

        }

        private void getKonyv(string con) {
            MySqlConnection mysqlCon = new

            MySqlConnection(con);
            mysqlCon.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT cim,id FROM kolcsonzesek WHERE kolcsonzokid=" + kolcsonzokBox.SelectedIndex + ";";
            adapter.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            konyvekBox.DataSource = bSource;
            konyvekBox.DisplayMember = "cim";
            konyvekBox.ValueMember = "id";


        }

        private void kolcsonzokBox_SelectedValueChanged(object sender, EventArgs e)
        {
            getKonyv("datasource=localhost;port=3306;Initial Catalog='konyvtar';username=root;password=");
        }

        private void konyvekBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (konyvekBox.SelectedItem == null)
            {
                visszahozBtn.Enabled = false;
            }
            else
            {
                visszahozBtn.Enabled = true;
            }
        }
    }
}
