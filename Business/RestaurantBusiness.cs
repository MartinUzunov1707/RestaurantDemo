using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Class that contains the business layer of the app.
    /// </summary>
    public class RestaurantBusiness
    {
        /// <summary>
        /// RestaurantContext Field to ensure communication between layers.
        /// </summary>
        private RestaurantContext RestaurantContext;
        /// <summary>
        /// A function that returns all the dishes in the database.
        /// </summary>
        /// <returns>List<Dish></returns>
        public List<Dish> GetAll()
        {
            using (RestaurantContext = new RestaurantContext())
            {
                return RestaurantContext.Dishes.ToList();
            }
        }
        /// <summary>
        /// A function that returns a Dish by a given ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Dish</returns>
        public Dish Get(int id)
        {
            using(RestaurantContext = new RestaurantContext())
            {
                return RestaurantContext.Dishes.Find(id);
            }
        }
        /// <summary>
        /// A function that adds a Dish to the database.
        /// </summary>
        /// <param name="dish"></param>
        public void Add(Dish dish)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                RestaurantContext.Dishes.Add(dish);
                RestaurantContext.SaveChanges();
            }
        }
        /// <summary>
        /// A function that updates a dish that is already in the database.
        /// </summary>
        /// <param name="dish"></param>
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
        /// <summary>
        /// A function that removes a Dish from the database by ID.
        /// </summary>
        /// <param name="id"></param>
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
