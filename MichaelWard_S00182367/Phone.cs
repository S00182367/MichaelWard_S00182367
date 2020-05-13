using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MichaelWard_S00182367
{
    public class Phone
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string OperatingSystem { get; set; }

        public string OS_Images { get; set; }

        public string Phone_Image { get; set; }

        Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
        Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");

        public void IncreasePrice(int precent)
        {
            Price * precent / 100;
        }

    }

   
}
