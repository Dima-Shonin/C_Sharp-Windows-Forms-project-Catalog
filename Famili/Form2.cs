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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        public DialogResult ShowDialog(string _Name,string _Country, string _Price)
        {

            textBox_Name.Text = _Name;
            textBox_Country.Text = _Country;
            maskedTextBox_Price.Text = _Price;
            return ShowDialog();
        }
        public string TName
        {
            get
            {
                return textBox_Name.Text; 
            }
        }
        public string TCountry
        {
            get
            {
                return textBox_Country.Text;
            }
        }
        public string TPrice
        {
            get
            {
                return maskedTextBox_Price.Text;
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
