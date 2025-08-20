using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL
{
    public class Order
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public bool Save(Order newOrder)
        {
            return true;
        }
        public List<Order> GetAll()
        {
            return new List<Order>();
        }
        public Order GetById(int id)
        {
            return new Order();
        }
        public bool Delete(int id)
        {
            return true;
        }
    }
}
