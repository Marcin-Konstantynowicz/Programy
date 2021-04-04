using Obliczenia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox1.Text = String.Empty;
            
        }
        public static string ans = String.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.Text += button1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
                textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
                textBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
                textBox1.Text += button13.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
                textBox1.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
                textBox1.Text += button17.Text;
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
                textBox1.Text += button18.Text;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
                textBox1.Text += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try { textBox1.Text = RPN.Calculate(textBox1.Text).ToString(); }
            catch (MyException ex) { textBox1.Text = ex.type; }
            
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += " e ";
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ^2 ";
        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ^ ";
        }
        

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans = String.Empty;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " \u03C0 ";

        }
        
        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sin(";
        }
        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "cos(";
        }
        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "tg(";
        }
        
        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(1/";
        }
        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "!";
        }
 
        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ln(";

        }
        
        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = (textBox1.Text.Substring(0, textBox1.Text.Length - 1));
        }

        
        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += " % ";
        }
        
        private void button33_Click(object sender, EventArgs e)
        {

        }

        
        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text += "atg(";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text += "P";
        }

        
        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text += "C";
        }
        
        private void button39_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void userControl11_Load(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void button33_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button33.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text += button40.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (ans.Length > 0)
                textBox1.Text += ans;  
            else
            {
                ans = textBox1.Text;
                textBox1.Text = String.Empty;
            }
                
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            info form = new info();
            form.Show();
        }
    }
} 