using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Model class for the Dish. Used in Database.
    /// </summary>
    public class Dish
    {
        public int ID { get; set; }
        public string DishName { get; set; }
        public double DishPrice { get; set; }
        public string DishDescription { get; set; }
        public byte[] Image { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool GlutenFree { get; set; }
        public bool Kosher { get; set; }
    }
}
