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
    /// Logika interakcji dla klasy Fiat.xaml
    /// </summary>
    public partial class Fiat : Window
    {
        public string[] fiatmodel { get; set; }
        public string[] fiatkolor { get; set; }
        public string[] fiatrok { get; set; }
        public string[] fiatpaliwo { get; set; }
        public Fiat()
        {
            InitializeComponent();
            fiatmodel = new string[] { "Ducato", "Panda", "Punto ", "Sedici", "Talento", "Tipo", "Spider", "Bravo", "Croma", "Linea", "Multipla"};
            fiatkolor = new string[] { "Czarny", "Biały", "Niebieski", "Szary", "Srebny", "Czerwony", "Zielony", "Żółty" };
            fiatrok = new string[] { "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            fiatpaliwo = new string[] { "Benzyna", "Diesel" };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
        List<string> Auta = new List<string>() { "Model" };
        private void fiatsave_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Fiat.txt", true))
                
                {
                    writer.WriteLine("Model:");
                    writer.WriteLine(fiatbox1.Text);
                    writer.WriteLine("Kolor:");
                    writer.WriteLine(fiatbox2.Text);
                    writer.WriteLine("Rok produkcji:");
                    writer.WriteLine(fiatbox3.Text);
                    writer.WriteLine("Rodzaj paliwa:");
                    writer.WriteLine(fiatbox4.Text);
                    writer.WriteLine("Czas dodania do bazy:");
                    writer.WriteLine(fiattime.Text);
                    writer.WriteLine("\n");
                    writer.Close();
                }
            MessageBoxResult result = MessageBox.Show("Pomyślnie zapisano auto Fiat.\r\nChcesz wpisać kolejny pojazd?", "Auta", MessageBoxButton.YesNo);
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
