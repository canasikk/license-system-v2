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
    public partial class VariableKey : Form
    {
        //Simple 
        Random rnd = new Random();
        string characters = "ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz012345678910";
        string gen, gen1, gen2, gen3;
        int charCount = 5;
        public VariableKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < charCount; i++)
                {
                    
                    gen += characters[rnd.Next(characters.Length)];
                    gen1 += characters[rnd.Next(characters.Length)];
                    //@canasikk
                    gen2 += characters[rnd.Next(characters.Length)];
                    gen3 += characters[rnd.Next(characters.Length)];
                    //OUTPUT XXXXX - XXXXX - XXXXX - XXXXX (5x4)


                }
                richTextBox1.Text += gen + "-" + gen1 + "-" + gen2 + "-" + gen3 + "\n";
                gen = ""; gen1 = ""; gen2 = ""; gen3 = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Application.StartupPath + @"\\Keys.txt";
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }//@canasikk
                File.AppendAllText(filePath, richTextBox1.Text, Encoding.UTF8);
                MessageBox.Show("File Saved -> " + Application.StartupPath + "\\Keys.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
        }
    }
}
