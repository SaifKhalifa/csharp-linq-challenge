using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_challenge
{
    internal class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        public Order(int id, int customerId, DateTime date, decimal total)
        {
            Id = id;
            CustomerId = customerId;
            Date = date;
            Total = total;
        }
    }
}
