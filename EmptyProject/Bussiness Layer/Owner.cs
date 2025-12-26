//Owner.cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject.Bussiness_Layer
{
    internal class Owner:Pizza_Details
    {
        public string order_id;
        public string amount;
        public string select_type;


        public string cust_id;
        public string name;
        public string mobile;
        public string address;

        public string quantity;
        public Owner()
        {
            
        }

        
        public Owner(string a, string b, string c, string d, string e)
        {
            pizza_id = a;
            pizza_name = b;
            select_type = c;
            price = d;
            description = e;

        }

        // Update Pizza Details
        public Owner(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            pizza_id = a;
            pizza_name = b;
            select_type = c;
            price = d;
            description = e;
        }

        // Save Order Information in ordpiza Table 
        public Owner(string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            pizza_id = a;
            pizza_name = b;
            quantity = c;
            price = d;
            description = e;
            cust_id = f;
            name = g;
            mobile = h;
            address = i;
        }

        //Receive Payment
        public Owner(string a, string b, string c, string e, string f, string g)
        {
            order_id = a;
            amount = b;
            select_type = c;
        }

        // saveCustomerIdDetails

        public Owner(string a, string b, string c, string d)
        {
            cust_id = a;
            name = b;
            mobile = c;
            address = d;
        }


        

        // delete Pizza Information
        public Owner(string a)
        {
            pizza_id = a;

        }

        // delete Order Information
        public Owner(string a, string b)
        {
            order_id = a;

        }

        // delete Customer Information
        public Owner(string a, string b, string c)
        {
            cust_id = a;

        }
    }
}
