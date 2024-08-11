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

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(255,0,0);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button2_Click(object sender, EventArgs e)//Сворачивание
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int detect = 1;
        private void fullscreen_Click(object sender, EventArgs e)
        {                  
            if (detect % 2 != 0) { this.WindowState = FormWindowState.Maximized; detect++; this.fullscreen.Text = "❐"; }
            else { this.WindowState = FormWindowState.Normal; detect++; this.fullscreen.Text = "☐"; }
        }
        int font = 28;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.Location = new System.Drawing.Point(275-font, 75);            
            this.textBox1.Size = new System.Drawing.Size(35+font, 60);
            font += 28;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ',';
        }
        
        private void roundButton14_Click(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '0';
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '1';
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '2';
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '3';
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '4';
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '5';
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '6';
        }

        private void roundButton12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '7';
        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '8';
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '9';
        }

        private void roundButton13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '+';
        }

        private void roundButton15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '-';
        }

        private void roundButton17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '✕';
        }

        private void roundButton16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += '÷';
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.textBox1.Location = new System.Drawing.Point(270,75);
            this.textBox1.Size = new System.Drawing.Size(35, 53);
            this.textBox1.Text = "0";
            font = 28;
        }
    }

}
