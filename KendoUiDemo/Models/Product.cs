using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUiDemo.Models
{
    public class Product
    {
        public int ProductID { set; get; }
        public string ProductName { set; get; }
        public int UnitsInStock { set; get; }
        public int UnitPrice { set; get; }
        public bool Discontinued { set; get; }
    }
}