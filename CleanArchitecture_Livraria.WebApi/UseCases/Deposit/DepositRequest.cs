﻿namespace CleanArchitecture_Livraria.WebApi.UseCases.Deposit
{
    using System;
    public class DepositRequest
    {
        public Guid AccountId { get; set; }
        public Double Amount { get; set; }
    }
}
