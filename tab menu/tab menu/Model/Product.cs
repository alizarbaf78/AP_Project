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

        public string Color { get; set; }
        //public bool AdvisePlass { get; set; }

        public string Weight { get; set; }
        public string Gender { set; get; }
        public string Shelf { get; set; }
        public bool IsExist { get; set; }
        public string money { get; set; }
        public Chang chang { set; get; }
    }
}
