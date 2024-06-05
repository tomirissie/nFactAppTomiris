using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nFactAppTomiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string searchQuery = textBox1.Text;

           
            var searchResults = PerformSearch(searchQuery);

            if (searchResults != null && searchResults.Count > 0)
            {
                
                string resultMessage = "Результаты поиска:\n";

                foreach (var result in searchResults)
                {
                    resultMessage += result + "\n";
                }

                MessageBox.Show(resultMessage, "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                MessageBox.Show("По вашему запросу ничего не найдено.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private List<string> PerformSearch(string searchQuery)
        {
            List<string> searchResults = new List<string>();

            searchResults.Add("Результат 1");
            searchResults.Add("Результат 2");
            searchResults.Add("Результат 3");

            return searchResults;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }



       
        private void button3_Click(object sender, EventArgs e)
        {


            richTextBox2.Text = "Прослушал(-а) альбом " + textBox2.Text + "   " + richTextBox1.Text +" Моя оценка:" + textBox4.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            string localHtmlFilePath = @"C:\Users\User\Documents\фактт.html";
            Process.Start("cmd", $"/c start {localHtmlFilePath}");
        }
    }
}
/* */

