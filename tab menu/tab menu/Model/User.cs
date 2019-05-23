using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tab_menu.Model
{
   public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage ="need to enter an your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "need to enter an your pass")]
        public string Pass { get; set; }
        
        public string PhonNumber { get; set; }
        public string FullName { get{return Name + "  " + LastName;}}
        public string BoughtProdect { get; set; }
        public string CodePosti { get; set; }
        public int GradeForProduct { get; set; }
        public Chang chang { set; get; }





    }
}
