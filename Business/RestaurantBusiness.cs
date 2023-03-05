using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Threading.Tasks;

namespace Business
{
    public class RestaurantBusiness
    {
        private RestaurantContext RestaurantContext;
        public List<Dish> GetAll()
        {
            using (RestaurantContext = new RestaurantContext())
            {
                return RestaurantContext.Dishes.ToList();
            }
        }
        public  Dish Get(int id)
        {
            using(RestaurantContext = new RestaurantContext())
            {
                return RestaurantContext.Dishes.Find(id);
            }
        }
        public void Add(Dish dish)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                RestaurantContext.Dishes.Add(dish);
                RestaurantContext.SaveChanges();
            }
        }
        public void Update(Dish dish)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                Dish item = RestaurantContext.Dishes.Find(dish.ID);
                if (item != null)
                {
                    RestaurantContext.Entry(item).CurrentValues.SetValues(dish);
                    RestaurantContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                Dish item = RestaurantContext.Dishes.Find(id);
                if (item != null)
                {
                    RestaurantContext.Dishes.Remove(item);
                    RestaurantContext.SaveChanges();
                }
            }
        }
    }
}
