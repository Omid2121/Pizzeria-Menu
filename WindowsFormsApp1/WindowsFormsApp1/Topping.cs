using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Toppings
    {
        public List<Topping> toppingList = new List<Topping>();
        public Toppings()
        {
            toppingList.AddRange(new List<Topping>
            {
                new Topping("Champignon", 20),
                new Topping("Polser", 20),
                new Topping("Ost", 20),
                new Topping("Tomatsauce", 10),
                new Topping("DeepPan", 30),
            });
        }
    }



    public class Topping
    {
        public string name;
        public int price;

        public Topping(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}




