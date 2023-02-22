using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link
{
    internal class Link2
    {
        public static void Main()
        {
            Food[] foods= {new Food(){ItemID=1,ItemName="Choco Shake" },
                new Food(){ItemID=2,ItemName="Mango Shake"},
                new Food(){ItemID=3,ItemName="Oreo Shake"},
                new Food(){ItemID=4,ItemName="Lime Soda"},
                new Food(){ItemID=5,ItemName="Apple Juice"},
                new Food(){ItemID=6,ItemName="Watermelon Juice"}
            };
            var qry=from shakes in foods
                    where shakes.ItemName.EndsWith("a")
                    select shakes;
            foreach(Food s in qry)
            {
                Console.WriteLine(s.ItemID+" "+s.ItemName);
            }
        }
    }
    class Food
    {
        public int ItemID { get; set; }
        public string? ItemName { get; set; }
    }


}
