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
            getKolcsonzok("datasource=localhost;port=3306;username=root;password=");
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

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT nev FROM kolcsonzok;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            kolcsonzokBox.DataSource = bSource;
        }
    }
}
