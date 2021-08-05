using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Famili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;
        string country;
        string price;
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();

            if (F.ShowDialog() == DialogResult.OK)
            {
                    name = F.TName;
                    country = F.TCountry;
                    price = F.TPrice;
                    listBox1.Items.Add(name + "\t" + country + "\t" + price);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }



        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
            }
            else
            {
                Form2 F = new Form2();
                string list = listBox1.SelectedItem.ToString();
                string[] words = list.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                name = words[0];
                country = words[1];
                price = words[2];
                if (F.ShowDialog(name, country, price) == DialogResult.OK)
                {
                    name = F.TName;
                    country = F.TCountry;
                    price = F.TPrice;
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Add(name + "\t" + country + "\t" + price);
                }
            }
            
                
        }
    }
}
