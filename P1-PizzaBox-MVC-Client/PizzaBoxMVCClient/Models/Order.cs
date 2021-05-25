using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Models
{
    public class Order
    {
       // public string UserName { get; set; }
        public List<Pizza> Pizzas { get; set; }
       // public User user { get; set; }
        public string Summary { get; set; }
        public int OrderId { get; set; }
        public DateTime? TimeReceived { get; set; }
        public int? StoreId { get; set; }
        public int? UserId { get; set; }
    }
}