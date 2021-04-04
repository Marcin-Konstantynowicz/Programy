
using Pojazdy;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Auta
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Auta", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Informacja wnd = new Informacja();
            wnd.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Wszystkie wnd = new Wszystkie();
            wnd.Show();
        }

        private void buttonfiat_Click(object sender, RoutedEventArgs e)
        {
            Fiat wnd = new Fiat();
            wnd.Show();
        }

        private void opelbutton_Click(object sender, RoutedEventArgs e)
        {
            Opel wnd = new Opel();
            wnd.Show();
        }

        private void nissanbutton_Click(object sender, RoutedEventArgs e)
        {
            Nissan wnd = new Nissan();
            wnd.Show();
        }

        private void bmwbutton_Click(object sender, RoutedEventArgs e)
        {
            BMW wnd = new BMW();
            wnd.Show();
        }

        private void mercbutton_Click(object sender, RoutedEventArgs e)
        {
            Mercedes wnd = new Mercedes();
            wnd.Show();
        }

    }
    
}
