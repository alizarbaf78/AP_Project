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

namespace tab_menu.FrontEnd
{
    /// <summary>
    /// Interaction logic for USign_up.xaml
    /// </summary>
    public partial class USign_up : UserControl
    {
        public USign_up()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ading ob2 = new ading();
            ob2.Signup(txt_firstname.Text, txt_last.Text, txt_mail.Text, tpass.Password, ctpass.Password,true);
            MessageBox.Show("salam");
        }
    }
}
