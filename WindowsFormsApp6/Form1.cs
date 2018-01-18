using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Month month;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }
        bool temp = false;
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if(temp == false)
            {
                textBox3.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
                temp = true;
                monthCalendar1.MinDate = Convert.ToDateTime(monthCalendar1.SelectionRange.Start.ToShortDateString());
                monthCalendar1.Visible = false;
            }
            else
            {
                textBox4.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
                monthCalendar1.MinDate = DateTime.Now;
                temp = false;
                monthCalendar1.Visible = false;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ekonom");
            comboBox1.Items.Add("Biznes");
            panel3.Visible = false;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }
        int count = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            label12.Text = Convert.ToString(++count);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label13.Text = Convert.ToString(count++);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label14.Text = Convert.ToString(count++);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(label12.Text == "0")
            {
                label12.Text = Convert.ToString(++count);
            }
            label12.Text = Convert.ToString(--count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label13.Text == "0")
            {
                label13.Text = Convert.ToString(++count);
            }
            label13.Text = Convert.ToString(--count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label14.Text == "0")
            {
                label14.Text = Convert.ToString(++count);
            }
            label14.Text = Convert.ToString(--count);
        }
    }
}
