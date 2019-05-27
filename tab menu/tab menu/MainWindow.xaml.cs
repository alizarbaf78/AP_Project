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

namespace tab_menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCurser.Margin = new Thickness(40 + (200 * index), 0, 0, 0);

            switch(index)
            {
                case 0:
                    his_page.Background = Brushes.Aquamarine;
                    break;
                case 1:
                    his_page.Background = Brushes.Beige;
                    break;
                case 2:
                    his_page.Background = Brushes.Azure;
                    break;
                case 3:
                    his_page.Background = Brushes.Black;
                    break;
                case 4:
                    his_page.Background = Brushes.Bisque;
                    break;


            }
        }

        private void btnclk1(object sender, RoutedEventArgs e)
        {
            // main.Content = new login();

            Window1 ob = new Window1();
            ob.Show();
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
