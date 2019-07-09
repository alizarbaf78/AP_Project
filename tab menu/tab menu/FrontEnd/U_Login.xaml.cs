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
using tab_menu;
namespace tab_menu.FrontEnd
{
    /// <summary>
    /// Interaction logic for U_Login.xaml
    /// </summary>
    public partial class U_Login : UserControl
    {
        //public event EventHandler UCButtonClicked;
        public U_Login()
        {
            InitializeComponent();
        }

        private void parent(object sender, RoutedEventArgs e)
        {
            //MainWindow.GetWindow.

            //hm.Lbl1.Visibility = Visibility.Hidden;
            //this.parent.
            ading ob1 = new ading();
            ob1.login_user(txt_email.Text,pastext.Password);

        }
    }
}
