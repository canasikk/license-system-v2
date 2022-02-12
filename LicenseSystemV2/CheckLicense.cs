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
    public partial class CheckLicense : Form
    {
        MySqlConnection db = new MySqlConnection("Server=localhost;Database=licensev2;Uid=root;Pwd='';");
        public CheckLicense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Close();
                db.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM lkey WHERE licenses = '" + textBox1.Text + "'", db);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (textBox1.Text == reader["licenses"].ToString())
                    {
                        MessageBox.Show("being used and end time " + reader["enddate"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Invalid key");
                        db.Close();
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
