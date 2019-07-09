using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_menu.FrontEnd
{
    class ading2
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
                    // MessageBox.Show(ex.Message);
                    return false;
                }

            }
        }




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
                    // MessageBox.Show("your pass is wrong");
                    return false;
                }



            }


        }



        public bool AddProduct(string name, string money, string color, string gender, string shelf, string weghit)
        {
            using (var db = new Model.Context())
            {


                db.products.Add(new Model.Product { Name = name, money = money, Color = color, IsExist = true, Gender = gender, Shelf = shelf, Weight = weghit });
                db.SaveChanges();
                return true;

            }
        }
    }
}
