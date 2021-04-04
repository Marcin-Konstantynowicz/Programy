using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Serwisowy
{
    public partial class przegladarka : Form
    {
        public przegladarka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void reflesh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void next_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void szukaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                webBrowser1.Navigate(textBox1.Text);
        }

        private void znak_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.znak.pl");
        }
    }
}
