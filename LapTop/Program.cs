using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTop
{
    internal class Program
    {
        class LapTop
        {
            internal string Name { get; set; } = "";

            internal string Manufacturer { get; set; } = "";

            internal double Price { get; set; } = 0;

            public LapTop()
            {
                Name = "Some Name";
                Manufacturer = "Some Manufacturer";
                Price = 99.99;
            }

            public LapTop(string Name, string Manufacturer, double Price)
            {
                this.Name = Name;
                this.Manufacturer = Manufacturer;
                this.Price = Price;
            }


            public void Print()
            {

                Console.WriteLine(Name);
                Console.WriteLine(Manufacturer);
                Console.WriteLine(Price);

            }
        }
        class Shop 
        {

            
             LapTop[] array_laptop = new LapTop[5];
            public string Name_magazine { get; set; } = "Some Magazine";
            public LapTop this[int index]
            {
                get
                {
                   return array_laptop[index];
                }
                set
                {
                    array_laptop[index] = value;
                }
            }

            public Shop()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Name_magazine); 
                Console.ResetColor();

                for (int i = 0; i < 5; i++) 
                {
                    array_laptop[i] = new LapTop();
                }
            }
            public Shop(string Name_magazine, LapTop array_laptop)
            {

                this.Name_magazine = Name_magazine;
               

            }
            public void ShopPrint()
            {
                Console.WriteLine(Name_magazine);
                for (int i = 0; i < 5; i++)
                {
                    
                    array_laptop[i].Print();
                }

            }

        }


        static void Main(string[] args)
        {
         Shop s = new Shop();
            
         s.ShopPrint();

            s[0].Name = "qeqe";
            s.ShopPrint();
        }
    }
}
