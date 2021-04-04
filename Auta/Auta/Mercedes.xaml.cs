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
    /// Logika interakcji dla klasy Mercedes.xaml
    /// </summary>
    public partial class Mercedes : Window
    {
        public string[] mercmodel { get; set; }
        public string[] merckolor { get; set; }
        public string[] mercrok { get; set; }
        public string[] mercpaliwo { get; set; }
        public Mercedes()
        {
            InitializeComponent();
            mercmodel = new string[] { "W168", "W198", "X204", "V251", "Viano", "Vito" , "Vaneo",  };
            merckolor = new string[] { "Czarny", "Biały", "Niebieski", "Szary", "Srebny", "Czerwony", "Zielony", "Żółty" };
            mercrok = new string[] { "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            mercpaliwo = new string[] { "Benzyna", "Diesel"};
            DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        List<string> Auta = new List<string>() { "Model" };
        private void mercsave_Click(object sender, RoutedEventArgs e)
        {
      
            using (StreamWriter writer = new StreamWriter("Mercedes-Benz.txt", true))
            {
                
                {
                    writer.WriteLine("Model:");
                    writer.WriteLine(mercbox1.Text);
                    writer.WriteLine("Kolor:");
                    writer.WriteLine(mercbox2.Text);
                    writer.WriteLine("Rok produkcji:");
                    writer.WriteLine(mercbox3.Text);
                    writer.WriteLine("Rodzaj paliwa:");
                    writer.WriteLine(mercbox4.Text);
                    writer.WriteLine("Czas dodania do bazy:");
                    writer.WriteLine(merctime.Text);
                    writer.WriteLine("\n");
                    writer.WriteLine("Następny pojazd:");
                    writer.Close();

                    MessageBoxResult result = MessageBox.Show("Pomyślnie zapisano auto Mercedes-Benz.\r\nChcesz wpisać kolejny pojazd?", "Auta", MessageBoxButton.YesNo);
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
    }
}
