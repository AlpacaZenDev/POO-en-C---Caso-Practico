using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public bool Save(OrderDetail newOrderDetail)
        {
            return true;
        }
        public List<OrderDetail> GetAll()
        {
            return new List<OrderDetail>();
        }
        public OrderDetail GetById(int id)
        {
            return new OrderDetail();
        }
        public bool Delete(int id)
        {
            return true;
        }
    }
}
