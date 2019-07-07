using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tab_menu
{
   public class Views
    {

        public void ViewInfoMember(string email)
        {
            using (var db = new Model.Context())
            {
                var check = db.users.SingleOrDefault(n => n.Email == email);

                Console.WriteLine(JsonConvert.SerializeObject(check));




            }


        }


        public void ViewAllMember()
        {
            using (var db = new Model.Context())
            {
                var check = db.users.Where(i => i.isExist.Equals(true));
                db.SaveChanges();
                Console.WriteLine(JsonConvert.SerializeObject(check));

            }


        }




        public void ViewAllProduct()
        {
            using (var db = new Model.Context())
            {
                var A = db.products.Where(x => x.IsExist.Equals(true));
                Console.WriteLine(JsonConvert.SerializeObject(A));

                db.SaveChanges();

            }

        }




    }
}
