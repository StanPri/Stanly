using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stanly.Models;

namespace Stanly.ViewModel
{
    public class MovieCustomerViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}