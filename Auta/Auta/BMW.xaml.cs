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
    /// Logika interakcji dla klasy BMW.xaml
    /// </summary>
    public partial class BMW : Window
    {
        public string[] bmwmodel { get; set; }
        public string[] bmwkolor { get; set; }
        public string[] bmwrok { get; set; }
        public string[] bmwpaliwo { get; set; }
        public BMW()
        {
            InitializeComponent();
            bmwmodel = new string[] { "E63", "E60", "E61", "E90", "E38", "E65", "E86" };
            bmwkolor = new string[] { "Czarny", "Biały", "Niebieski", "Szary", "Srebny" };
            bmwrok = new string[] { "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            bmwpaliwo = new string[] { "Benzyna", "Diesel" };
            DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        List<string> Auta = new List<string>() { "Model" };
        private void bmwsave_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("BMW.txt", true ))
                
            {
                    writer.WriteLine("Model:", bmwbox1.Text);
                    writer.WriteLine(bmwbox1.Text);
                    writer.WriteLine("Kolor:");
                    writer.WriteLine(bmwbox2.Text);
                    writer.WriteLine("Rok produkcji:");
                    writer.WriteLine(bmwbox3.Text);
                    writer.WriteLine("Rodzaj paliwa:");
                    writer.WriteLine(bmwbox4.Text);
                    writer.WriteLine("Czas dodania do bazy:");
                    writer.WriteLine(timebmw.Text);
                    writer.WriteLine("\n");
                    writer.Close();
            }
                MessageBoxResult result = MessageBox.Show("Pomyślnie zapisano auto BMW.\r\nChcesz wpisać kolejny pojazd?", "Auta", MessageBoxButton.YesNo);
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
