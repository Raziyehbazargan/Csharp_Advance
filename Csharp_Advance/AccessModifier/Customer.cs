using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Csharp_Advance.AccessModifier
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1");
            }
            else
            {
                Console.WriteLine("Promoted to level2");
            }
        }
        private int CalculateRating()
        {
            return 0;
        }
    }
}
