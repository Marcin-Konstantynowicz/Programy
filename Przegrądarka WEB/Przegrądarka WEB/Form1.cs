using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przegrądarka_WEB
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


        private void end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           webBrowser1.GoBack();
        }

        private void Szukaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)133)
                webBrowser1.Navigate(textBox1.Text);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Informacje wnd = new Informacje();
            wnd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.znak.pl");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.basewin.pl");
        }
    }
} 
