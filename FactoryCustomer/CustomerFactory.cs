using System;
using System.Collections.Generic;
using MiddleLayer;

namespace FactoryCustomer
{
    public static class CustomerFactory
    {
        private static Dictionary<string, BaseCustomer> baseCustomer = new Dictionary<string, BaseCustomer>();

        public static BaseCustomer Create(string customerName)
        {
            //We did lazy loading here, when needed then only we Loading customer collection.
            BaseCustomer.LoadCustomers();
            //It replaced to check conditions, used Replace If with Polymorphism(RIP) Condition.
            return baseCustomer[customerName];
        }
    }
}
