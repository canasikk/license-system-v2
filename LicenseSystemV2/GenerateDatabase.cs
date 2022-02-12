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
    public partial class GenerateDatabase : Form
    {
        MySqlConnection db = new MySqlConnection("Server=localhost;Database=licensev2;Uid=root;Pwd='';");
        MySqlCommand cmd = new MySqlCommand();
        public GenerateDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Guid.NewGuid().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Close();
            db.Open();
            if (db.State != ConnectionState.Closed)
            {
                db.Close();
                cmd.Connection = db;
                cmd.CommandText = "insert into lkey(licenses,enddate) values('" + textBox1.Text + "', '" + dateTimePicker1.Value.ToShortDateString() + "')";
                db.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                db.Close();
                MessageBox.Show("Added!");



            }
            else
            {
                MessageBox.Show("Errr!");
                db.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i< numericUpDown1.Value;i++) {
                listBox1.Items.Add(Guid.NewGuid().ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Close();
            db.Open();
            if (db.State != ConnectionState.Closed)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    db.Close();
                    cmd.Connection = db;
                    cmd.CommandText = "insert into lkey(licenses,enddate) values('" + listBox1.Items[i].ToString() + "', '" + dateTimePicker2.Value.ToShortDateString() + "')";
                    db.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    db.Close();
                }
                MessageBox.Show("Added!");

            }
            else
            {
                MessageBox.Show("Errr!");
                db.Close();
            }
        }
    }
}
