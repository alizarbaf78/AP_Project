using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace tab_menu
{
    public class LOGIN
    {
        public bool login(string email, string password)
        {
            using (var db = new Model.Context())
            {

                var res = db.users.Where(i => i.Email == email && i.Pass == password).FirstOrDefault();

                var query = from e in db.users
                            where e.Email == email
                            select e;
                db.SaveChanges();
                try
                {

                    if (res != null)
                    {
                       
                        foreach (var item in query)
                        {
                            Console.WriteLine("hello" + item.FullName + "    welcome");
                            

                        }
                       
                    }
                    return true;


                }
                 
                catch (Exception ex)
                {

                    Console.WriteLine("your pass is wrong");
                    MessageBox.Show(ex.Message);
                    return false;
                }
               

               

            }


        }

    }
}
