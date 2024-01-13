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

        string[] phonetic = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett",
            "Kilo", "Lima", "Mike", "November", "Oscar", "Papa","Quebec", "Romeo","Sierra","Tango","Uniform","Victor","Whiskey","Xray","Yankee","Zulu" };
        char[] phonetic_2 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


        // nato to aplhabet
        DateTime strt;
        int val;
        char[] refr = new char[60];
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            val = (int)numericUpDown1.Value;
            button2.Enabled = true;
            string[] outp= new string[val];
            var rand = new Random();

            for (int i=0;i<val;i++)
            {
                int b = rand.Next(26);
                outp[i] = phonetic[b];
                refr[i] = phonetic_2[b];
                
            }
            for(int i = 0; i < val; i++)
            {
                label2.Text += outp[i] + " ";
            }

            strt = DateTime.Now;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            label4.Text = "";
            TimeSpan result = DateTime.Now-strt;
            char[] inp=new char[textBox1.TextLength];

            string s = textBox1.Text.Replace(" ", "");
            for (int i = 0; i < val; i++)
            {
                inp[i] = s.ElementAt(i);
            }
            bool is_gd=true;
            for(int i = 0; i < val; i++)
            {
                if (char.ToUpper(inp[i]) != refr[i])
                {
                    int ii = i+1;
                    label4.Text += "ошибка в "+ ii + " символе\n";
                    is_gd = false;
                }
            }
            if (is_gd == true)
            {
                label4.Text = "Все правильно";
            }
            

        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {/*
            if (e.KeyChar == (char)Keys.Return)

            {
                TimeSpan result = DateTime.Now - strt;
                string inp = textBox1.Text;
                if (inp.ToUpper() == aft)
                {
                    MessageBox.Show("good " + result.Seconds.ToString());
                }
                else
                {
                    MessageBox.Show("not good");
                }
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------
    }
}
