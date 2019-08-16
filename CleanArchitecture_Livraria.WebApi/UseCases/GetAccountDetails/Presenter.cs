namespace CleanArchitecture_Livraria.WebApi.UseCases.GetAccountDetails
{
    using CleanArchitecture_Livraria.Application;
    using CleanArchitecture_Livraria.Application.Outputs;
    using CleanArchitecture_Livraria.WebApi.Model;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class Presenter : IOutputBoundary<AccountOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public AccountOutput Output { get; private set; }

        public void Populate(AccountOutput output)
        {
            Output = output;

            if (output == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            List<TransactionModel> transactions = new List<TransactionModel>();

            foreach (var item in output.Transactions)
            {
                var transaction = new TransactionModel(
                    item.Amount,
                    item.Description,
                    item.TransactionDate);

                transactions.Add(transaction);
            }

            ViewModel = new ObjectResult(new AccountDetailsModel(
                output.AccountId,
                output.CurrentBalance,
                transactions));
        }
    }
}
