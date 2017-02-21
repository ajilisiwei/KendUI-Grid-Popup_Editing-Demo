using KendoUiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using KendoUiDemo.CommonHelpers;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace KendoUiDemo.Controllers
{
    public class ProductsController : Controller
    {
        private static List<Product> products = new List<Product>()
            {
                new Product(){ProductID=10,ProductName="testPro1",UnitPrice=12,UnitsInStock=12,Discontinued=false},
                new Product(){ProductID=11,ProductName="testPro2",UnitPrice=1,UnitsInStock=12,Discontinued=false},
                new Product(){ProductID=12,ProductName="testPro3",UnitPrice=17,UnitsInStock=12,Discontinued=true},
                new Product(){ProductID=13,ProductName="testPro4",UnitPrice=22,UnitsInStock=12,Discontinued=false},
                new Product(){ProductID=14,ProductName="testPro5",UnitPrice=2,UnitsInStock=12,Discontinued=false},
                new Product(){ProductID=15,ProductName="testPro6",UnitPrice=102,UnitsInStock=12,Discontinued=true},
                new Product(){ProductID=16,ProductName="testPro7",UnitPrice=124,UnitsInStock=12,Discontinued=false},
                new Product(){ProductID=17,ProductName="testPro8",UnitPrice=132,UnitsInStock=12,Discontinued=true},
                new Product(){ProductID=18,ProductName="testPro9",UnitPrice=100,UnitsInStock=12,Discontinued=false},
                new Product(){ProductID=19,ProductName="testPro10",UnitPrice=12,UnitsInStock=12,Discontinued=false},
            };

        public JsonResult Products()
        {
            return this.Jsonp(products);
        }


        public JsonpResult Update(string models)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Product> updatedPros = serializer.Deserialize<List<Product>>(models);
            //Product updatedPro2 = (Product)JsonConvert.DeserializeObject(filtermodels);
            return this.Jsonp(updatedPros[0]);
        }

    }
}
