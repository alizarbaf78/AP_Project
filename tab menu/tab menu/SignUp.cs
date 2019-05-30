using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace tab_menu
{
    public class SignUp
    {
        public bool Signup(string first, string last, string email, string password, string confirm_password)
        {
            using (var db = new Model.Context())
            {
                try
                {
                    if (password == confirm_password)
                    {

                        db.users.Add(new Model.User { Name = first, LastName = last, Email = email, Pass = password });
                        db.SaveChanges();

                    }
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("your pass is wrong");
                    return false;
                }



            }


        }




    }
}
