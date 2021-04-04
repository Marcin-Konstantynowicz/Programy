using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Auta
{
    /// <summary>
    /// Logika interakcji dla klasy Opel.xaml
    /// </summary>
    public partial class Opel : Window
    {
        public string[] opelmodel { get; set; }
        public string[] opelkolor { get; set; }
        public string[] opelrok { get; set; }
        public string[] opelpaliwo { get; set; }
        public Opel()
        {
            InitializeComponent();
            opelmodel = new string[] { "Astra", "Corsa", "Combo", "Mokka", "Vivaro", "Zafira", "Insignia", "Combo", "Grandland X", "Vectra B"};
            opelkolor = new string[] { "Czarny", "Biały", "Niebieski", "Szary", "Srebny", "Czerwony", "Zielony", "Żółty" };
            opelrok = new string[] { "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            opelpaliwo = new string[] { "Benzyna", "Diesel" };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        List<string> Auta = new List<string>() { "Model" };
        private void opelsave_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Opel.txt", true))

            {
                writer.WriteLine("Model:");
                writer.WriteLine(opelbox1.Text);
                writer.WriteLine("Kolor:");
                writer.WriteLine(opelbox2.Text);
                writer.WriteLine("Rok produkcji:");
                writer.WriteLine(opelbox3.Text);
                writer.WriteLine("Rodzaj paliwa:");
                writer.WriteLine(opelbox4.Text);
                writer.WriteLine("Czas dodania do bazy:");
                writer.WriteLine(opeltime.Text);
                writer.Close();
            }

                MessageBoxResult result = MessageBox.Show("Wysłano SMS.");
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show("Wybierz ponownie pojazd.", "Auta");
                        break;
                    case MessageBoxResult.No:
                        this.Close();
                        break;
                }
            
        }
    }
}
