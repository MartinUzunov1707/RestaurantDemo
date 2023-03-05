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
        private RestaurantContext restaurantContext;
        public List<Dish> GetAll()
        {
            using (restaurantContext = new RestaurantContext())
            {
                return restaurantContext.Dishes.ToList();
            }
        }
        public  Dish Get(int id)
        {
            using(restaurantContext = new RestaurantContext())
            {
                return restaurantContext.Dishes.Find(id);
            }
        }

        public void Add(Dish dish)
        {
            using (restaurantContext = new RestaurantContext())
            {
                restaurantContext.Dishes.Add(dish);
                restaurantContext.SaveChanges();
            }
        }
        public void Update(Dish dish)
        {
            using (restaurantContext = new RestaurantContext())
            {
                Dish item = restaurantContext.Dishes.Find(dish.ID);
                if (item != null)
                {
                    restaurantContext.Entry(item).CurrentValues.SetValues(dish);
                    restaurantContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (restaurantContext = new RestaurantContext())
            {
                Dish item = restaurantContext.Dishes.Find(id);
                if (item != null)
                {
                    restaurantContext.Dishes.Remove(item);
                    restaurantContext.SaveChanges();
                }
            }
        }
    }
}
