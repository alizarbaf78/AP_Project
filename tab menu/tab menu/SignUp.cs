using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_menu
{
    public class SignUp
    {
        public void Signup(string first, string last, string email, string password, string confirm_password)
        {
            using (var db = new Model.Context())
            {
                if (password == confirm_password)
                {

                    db.users.Add(new Model.User { Name = first, LastName = last, Email = email, Pass = password });

                }
                else
                {
                    Console.WriteLine("your pass is wrong ");
                }


            }


        }




    }
}
