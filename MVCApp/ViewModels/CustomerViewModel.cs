using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public List<Customer> Customers { get; set; }
    }
}