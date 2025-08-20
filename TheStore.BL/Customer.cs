using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        /*
         * Métodos: Save, Get (get all, get by id), delete
         */

        // Save
        public bool Save(Customer newCustomer)
        {
            return true;
        }

        // Get All
        public List<Customer> GetAll()
        {
            return new List<Customer>();
        }

        // Get by id
        public Customer GetById(int id)
        {
            return new Customer();
        }

        // Delete
        public bool Delete(int id)
        {
            return true;
        }

    }


}
