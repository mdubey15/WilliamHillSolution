using System;
using System.Collections.Generic;

namespace MiddleLayer
{
    public class RedbetCustomer : BaseCustomer
    {
        public RedbetCustomer()
        {
        }

        #region properties

        public string FaviouriteFootballTeam { get; set; }

        #endregion

        #region Method

        public override bool Validate()
        {
            var res = (FirstName.Length == 0) ||
                (LastName.Length == 0) ||
                (Address.Length == 0) ||
                (FaviouriteFootballTeam.Length == 0);

            return res;
        }

        public bool Register(RedbetCustomer Customer)
        {
            Validate();
            this.FirstName = Customer.FirstName;
            this.LastName = Customer.LastName;
            this.Address = Customer.Address;
            this.FaviouriteFootballTeam = Customer.FaviouriteFootballTeam;

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
