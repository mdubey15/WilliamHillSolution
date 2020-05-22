using System;
using System.Collections.Generic;

namespace MiddleLayer
{
    public class MrGreenCustomer : BaseCustomer
    {
        public MrGreenCustomer()
        {
        }


        #region properties

        public string PersonalNumber { get; set; }

        #endregion

        #region Method

        public override bool Validate()
        {
            var res = (FirstName.Length == 0) || (LastName.Length == 0) || (Address.Length == 0) || (PersonalNumber.Length==0) ;

            return res;
        }

        public bool Register(MrGreenCustomer Customer)
        {
            Validate();
            this.FirstName = Customer.FirstName;
            this.LastName = Customer.LastName;
            this.Address = Customer.Address;
            this.PersonalNumber = Customer.PersonalNumber;
            
            return true;
        }

        public new string View()
        {
            return string.Empty;
        }

        public new string Modify()
        {
            return string.Empty;
        }

        #endregion
    }

}
