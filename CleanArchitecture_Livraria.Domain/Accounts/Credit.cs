﻿namespace CleanArchitecture_Livraria.Domain.Accounts
{
    using CleanArchitecture_Livraria.Domain.ValueObjects;
    using System;

    public class Credit : Transaction
    {
        protected Credit()
        {

        }

        public Credit(Guid accountId, Amount amount)
            : base(accountId, amount)
        {

        }

        public override string Description
        {
            get
            {
                return "Credit";
            }
        }
    }
}
