using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_menu.Controler
{
    public class dbcontroler
    {
        public List<Model.Product> Allproducts()
        {
            try
            {
                var db = new Model.Context();
                return db.products.ToList<Model.Product>();
                

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
