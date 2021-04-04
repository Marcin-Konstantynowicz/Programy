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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basewin wnd = new basewin();
            wnd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            system wnd = new system();
            wnd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           ninite wnd = new ninite();
            wnd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            classicshell wnd = new classicshell();
            wnd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drukarka wnd = new drukarka();
            wnd.Show();
        }

        private void web_Click(object sender, EventArgs e)
        {
            przegladarka wnd = new przegladarka();
            wnd.Show();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
           informacje wnd = new informacje();
           wnd.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
