using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
Привет сережа

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Enabled = false;

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                button1.Enabled = true;

            }
        }

        private void textBox3_MouseMove(object sender, MouseEventArgs e)
        {
            textBox3.BackColor = Color.Red;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < '0' || e.KeyValue > '9') && e.Modifiers != Keys.Control)
                e.SuppressKeyPress = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < '0' || e.KeyValue > '9') && e.Modifiers != Keys.Control)
                e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double z1;
            double z2;

            if (radioButton1.Checked)
                a *= Math.PI / 180;

            if (radioButton1.Checked)
                b *= Math.PI / 180;

            z1 = Math.Pow((Math.Cos(a) - Math.Cos(b)), 2) - Math.Pow((Math.Sin(a) - Math.Sin(b)), 2);
            textBox3.Text += Environment.NewLine + "z1 = " + z1.ToString();
            z2 = -4 * Math.Pow(Math.Sin(1), 2) * ((a - b) / 2) * Math.Cos(a + b);
            textBox3.Text += Environment.NewLine + "z2 = " + z2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void pictureBox1_Move(object sender, EventArgs e)
        {
            
        }
    }
    }

