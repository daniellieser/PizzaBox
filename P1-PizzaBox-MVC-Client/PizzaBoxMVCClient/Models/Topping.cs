using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Models
{
  public class Topping
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
        
    }
}