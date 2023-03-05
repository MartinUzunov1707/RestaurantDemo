using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("name=RestaurantContext") { }
        public DbSet<Dish> Dishes { get; set; }
    }
}
