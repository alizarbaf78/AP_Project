using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_menu.Model
{
   public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
       // public string LastName { get; set; }
        public string Color { get; set; }
        public bool AdvisePlass { get; set; }
        // public int Number { get; set; }
        // public string FullName { get { return Name + "  " + LastName; } }
        public string Weight { get; set; }
        public string Type { set; get; }
        public Chang chang { set; get; }
    }
}
