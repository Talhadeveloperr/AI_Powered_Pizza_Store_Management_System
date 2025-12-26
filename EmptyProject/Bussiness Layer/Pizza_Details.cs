//Pizza_Details.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject.Bussiness_Layer
{
    internal class Pizza_Details
    {
        public string pizza_id;
        public string pizza_name;
        public string price;
        public string description;
        public void pizza_details(string a, string b, string d, string e)
        {
            pizza_id = a;
            pizza_name = b;
            price = d;
            description = e;
        }
    }
}
