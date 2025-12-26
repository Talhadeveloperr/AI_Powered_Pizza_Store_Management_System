//Customer.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject.Bussiness_Layer
{
    internal class Customer
    {
        public string cust_id;
        public string name;
        public string mobile;
        public string address;


        public string feedback;

       

        public Customer()
        {

        }


        public Customer(string a, string b)
        {
            name = a;
            feedback = b;
        }



        public void Feedback(string a, string b)
        {
            name = a;
            feedback = b;
        }


        public void Order()
        {

        }
    }
}
