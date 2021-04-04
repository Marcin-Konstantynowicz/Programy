using Microsoft.Win32;
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

namespace Pojazdy
{
    /// <summary>
    /// Logika interakcji dla klasy Wszystkie.xaml
    /// </summary>
    public partial class Wszystkie : Window
    {
        public Wszystkie()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
 
        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            listabox.Text = "Modele Mercedes-Benz:";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == null)
                openFileDialog.InitialDirectory = @"C:\Users\Marcin\source\repos\Auta\Auta\bin\Debug\Mercedes-Benz.txt";
            listabox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            listabox.Text = "Modele Opla:";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == null)
                openFileDialog.InitialDirectory = @"C:\Users\Marcin\source\repos\Auta\Auta\bin\Debug\Opel.txt";
            listabox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == null)
                openFileDialog.InitialDirectory = @"C:\Users\Marcin\source\repos\Auta\Auta\bin\Debug\Nissan.txt";
            listabox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            listabox.Text = "Modele Fiata:";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == null)
                openFileDialog.InitialDirectory = @"C:\Users\Marcin\source\repos\Auta\Auta\bin\Debug\Fiat.txt";
            listabox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            listabox.Text = "Modele BMW:";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == null)
                openFileDialog.InitialDirectory = @"C:\Users\Marcin\source\repos\Auta\Auta\bin\Debug\BMW.txt";
            listabox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void listabox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listboxall_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
