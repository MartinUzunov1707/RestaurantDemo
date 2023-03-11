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
        public Dish(int id, string name, decimal price, string desc, byte[] image, bool isveg, bool isvegan, bool isglutenfree, bool iskosher)
        {
            ID = id;
            DishName= name;
            DishPrice= price;
            DishDescription= desc;
            Image = image;
            IsVegetarian= isveg;
            IsVegan= isvegan;
            IsGlutenFree= isglutenfree;
            IsKosher = iskosher;
        }
        public int ID { get; set; }
        public string DishName { get; set; }
        public decimal DishPrice { get; set; }
        public string DishDescription { get; set; }
        public byte[] Image { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsKosher { get; set; }
    }
}
