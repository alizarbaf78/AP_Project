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
using tab_menu.FrontEnd;
using tab_menu.Controler;
using tab_menu.BackEnd;

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

            //GridCurser.Margin = new Thickness(40 + (200 * index), 0, 0, 0);

            switch (index)
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
                    his_page.Background = Brushes.RoyalBlue;
                    break;
                case 4:
                    his_page.Background = Brushes.Bisque;
                    break;


            }
            switch (index)
            {
                case 0:
                    ucn.Background = Brushes.Aquamarine;
                    break;
                case 1:
                    ucn.Background = Brushes.Beige;
                    break;
                case 2:
                    ucn.Background = Brushes.Azure;
                    break;
                case 3:
                    ucn.Background = Brushes.RoyalBlue;
                    break;
                case 4:
                    ucn.Background = Brushes.Bisque;
                    break;


            }
        }

        
        //private void btnclk2(object sender, RoutedEventArgs e)
        //{
        //    sign_up sign = new sign_up();

            

        //}

        private void u1_click(object sender, RoutedEventArgs e)
        {
            U_Login ulogin = new U_Login();

            ugrid.Children.Add(ulogin);



        }

        private void close(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void u2_click(object sender, RoutedEventArgs e)
        {
            //ugrid.Children.Clear();
            USign_up signup = new USign_up();
            ugrid.Children.Add(signup);

            
        }

        

        private void close_U(object sender, RoutedEventArgs e)
        {
            ugrid.Children.Clear();
            productgrid.Children.Clear();
            //ugrid.Children.Clear();
            
        }

        private void show(object sender, RoutedEventArgs e)
        {
            Uproduct ujk = new Uproduct();
            productgrid.Children.Add(ujk);
            //Views vv = new Views();
            //ujk.pnam.Text = vv.viewoneproduct("mobile");
            //try
            //{
            //    Controler.dbcontroler dBController = new Controler.dbcontroler();
            //    List<Model.Product> products = dBController.Allproducts();
            //    //foreach (var item in products)
            //    //{
            //    //    ////Uproduct uproductshow = new Uproduct();
            //    //    //////uproductshow.AddHandler(item);
            //    //    ////ucn.Children.Add(uproductshow);
            //    //}
                
            //    //    UC.Product Show product Show = new UC.Product Show();
            //    //product Show.Add Data(item);
            //    //xpanel.Children.Add(productShowUC);
                
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "errror");
            //}
        }
    }
}
