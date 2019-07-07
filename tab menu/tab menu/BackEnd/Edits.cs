using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_menu
{
    public class Edits
    {
        public bool edit_product(string Pname, string name, string money, string color, string gender, string shelf, string weight)
        {
            using (var db = new Model.Context())
            {
                var A = db.products.SingleOrDefault(x => x.Name == Pname);
                db.products.Remove(A);
                db.products.Add(new Model.Product { Name = name, money = money, Color = color, IsExist = true, Gender = gender, Shelf = shelf, Weight = weight });
                db.SaveChanges();

            }

            var db2 = new Model.Context();
            var A2 = db2.products.SingleOrDefault(x => x.Name == name);
            if (A2 != null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }




        public bool edit_user(string Pemail, string email, string fname, string lname, string password)
        {
            using (var db = new Model.Context())
            {
                var A = db.users.SingleOrDefault(x => x.Email == Pemail);
                db.users.Remove(A);
                db.users.Add(new Model.User { Name = fname, LastName = lname, Pass = password, Email = email });
                db.SaveChanges();

            }

            var db2 = new Model.Context();
            var A2 = db2.users.Single(x => x.Email == email);
            if (A2 != null)
            {
                return true;
            }
            else
            {
                return false;
            }




        }


        public bool remove_product(string name)
        {

            using (var db = new Model.Context())
            {
                var A = db.products.SingleOrDefault(x => x.Name == name);
                db.products.Remove(A);
                db.SaveChanges();
            }

            var db2 = new Model.Context();
            var A2 = db2.products.SingleOrDefault(x => x.Name == name);
            if (A2 != null)
            {
                return false;
            }

            else
            {
                return true;
            }



        }







    }
}
