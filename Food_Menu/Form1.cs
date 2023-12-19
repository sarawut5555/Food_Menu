using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Food_Menu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private int CalculateTotal()
        {
            int menu1 = 30;
            int menu2 = 30;
            int menu3 = 30;
            int menu4 = 30;
            int menu5 = 40;
            int menu6 = 40;
            int menu7 = 50;
            int menu8 = 60;
            int menu9 = 10;
            int menu10 = 5;
            int total = 0;

            if (checkBox1.Checked)
            {
                total += menu1;
            }

            if (checkBox2.Checked)
            {
                total += menu2;
            }

            if (checkBox3.Checked)
            {
                total += menu3;
            }

            if (checkBox4.Checked)
            {
                total += menu4;
            }

            if (checkBox5.Checked)
            {
                total += menu5;
            }

            if (checkBox6.Checked)
            {
                total += menu6;
            }

            if (checkBox7.Checked)
            {
                total += menu7;
            }

            if (checkBox8.Checked)
            {
                total += menu8;
            }

            if (checkBox9.Checked)
            {
                total += menu9;
            }

            if (checkBox10.Checked)
            {
                total += menu10;
            }

            return total;
        }
        private string GetSelectedFoods()
        {
            List<string> selectedFoods = new List<string>();

            if (checkBox1.Checked)
            {
                selectedFoods.Add(checkBox1.Text);
            }

            if (checkBox2.Checked)
            {
                selectedFoods.Add(checkBox2.Text);
            }

            if (checkBox3.Checked)
            {
                selectedFoods.Add(checkBox3.Text);
            }

            if (checkBox4.Checked)
            {
                selectedFoods.Add(checkBox4.Text);
            }

            if (checkBox5.Checked)
            {
                selectedFoods.Add(checkBox5.Text);
            }

            if (checkBox6.Checked)
            {
                selectedFoods.Add(checkBox6.Text);
            }

            if (checkBox7.Checked)
            {
                selectedFoods.Add(checkBox7.Text);
            }

            if (checkBox8.Checked)
            {
                selectedFoods.Add(checkBox8.Text);
            }

            if (checkBox9.Checked)
            {
                selectedFoods.Add(checkBox9.Text);
            }

            if (checkBox10.Checked)
            {
                selectedFoods.Add(checkBox10.Text);
            }

            return string.Join(" \n",selectedFoods);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int total = CalculateTotal();
            string selectedFoods = GetSelectedFoods();
            label3.Text = selectedFoods;
            textBox1.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            label3.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
