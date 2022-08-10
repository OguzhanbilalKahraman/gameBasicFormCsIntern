using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irelia.Models
{
    public class Hesap
    {
    
        
        public string kullaniciAdi { get; set; }


        public string rol { get; set; }

        public int damage { get; set; }

        Random random = new Random();
        public void Saldiri()
        {
            damage += random.Next(450, 1000);
        }


    }

}
