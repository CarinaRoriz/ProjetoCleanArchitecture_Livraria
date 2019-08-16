﻿namespace CleanArchitecture_Livraria.WebApi.UseCases.Withdraw
{
    using CleanArchitecture_Livraria.Application;
    using CleanArchitecture_Livraria.Application.UseCases.Withdraw;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<WithdrawOutput>
    {
        public IActionResult ViewModel { get; private set; }

        public WithdrawOutput Output { get; private set; }

        public void Populate(WithdrawOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(new
            {
                Amount = response.Transaction.Amount,
                Description = response.Transaction.Description,
                TransactionDate = response.Transaction.TransactionDate,
                UpdateBalance = response.UpdatedBalance,
            });
        }
    }
}
