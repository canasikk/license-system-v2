using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace LicenseSystemV2
{
    public partial class ShowDatabaseItems : Form
    {
         
        public ShowDatabaseItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=licensev2;Uid=root;Pwd='';");
            db.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * from lkey", db);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();
        }
    }   
}
