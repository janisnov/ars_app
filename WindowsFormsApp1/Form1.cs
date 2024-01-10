using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            webBrowser1.Navigate(AppDomain.CurrentDomain.BaseDirectory + "data/htmls/" + treeView1.SelectedNode.Name + ".html");//sending addres of hrml to web viewer
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        string[] phonetic = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett",
            "Kilo", "Lima", "Mike", "November", "Oscar", "Papa","Quebec", "Romeo","Sierra","Tango","Uniform","Victor","Whiskey","Xray","Yankee","Zulu" };
        string[] phonetic_2 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J","K", "L", "M", "N", "O", "P","Q", "R","S","T","U","V","W","X","Y","Z" };

        string aft = "";
        DateTime strt;
        private void button1_Click(object sender, EventArgs e)
        {
            aft = "";
            button2.Enabled = true;
            string outp = "";
            int val = (int)numericUpDown1.Value;
            var rand = new Random();

            for (int i=0;i<val;i++)
            {
                int b = rand.Next(26);
                
                if (outp == "")
                {
                    outp += phonetic[b];
                    aft += phonetic_2[b];
                }
                else
                {
                    outp += ", " + phonetic[b];
                    aft += phonetic_2[b];
                }
            }
            label2.Text = outp;
            strt = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan result = DateTime.Now-strt;
            string inp = textBox1.Text;
            if (inp.ToUpper() == aft)
            {
                MessageBox.Show("good "+ result.Seconds.ToString());
            }
            else
            {
                MessageBox.Show("not good");
            }
            
        }
    }
}
