using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseSystemV2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateDatabase gd = new GenerateDatabase();
            gd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDatabaseItems sdi = new ShowDatabaseItems();
            sdi.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VariableKey vk = new VariableKey();
            vk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckLicense cl = new CheckLicense();
            cl.ShowDialog();
        }
    }
}
