using System;
using System.Collections.Generic;

namespace MiddleLayer
{
    //Base Contract with different brands
    public abstract class BaseCustomer
    {
        public BaseCustomer()
        {
        }

        public static Dictionary<string, BaseCustomer> baseCustomer = new Dictionary<string, BaseCustomer>();

        #region properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName ; }}

        public string Address { get; set; }

        public static Dictionary<string, BaseCustomer> baseCustomers()=>LoadCustomers();

        #endregion

        #region Method

        public abstract bool Validate();

        public bool Register(object baseCustomer)
        {
            if (baseCustomer == null)
            {
                return false;

            }
                return true;
        }

        //TODO
        public string View()
        {
            throw new NotImplementedException();
        }

        //TODO
        public string Modify()
        {
            throw new NotImplementedException();
        }

        public static Dictionary<string,BaseCustomer> LoadCustomers()
        {
            if (baseCustomer.Count <= 0)
            {
                //Here create new object of whatever brands come and add it to the Base Customer collection.
                baseCustomer.Add("MrGreen", new MrGreenCustomer());
                baseCustomer.Add("Redbet", new RedbetCustomer());
            }
            return baseCustomer;
        }

        #endregion
    }
}
