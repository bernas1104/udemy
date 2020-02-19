using System;
using Section14.Entities;

namespace Section14.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _paymentService { get; set; }

        public ContractService(IOnlinePaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for(int i = 0; i < months; i++)
            {
                double amount = contract.TotalValue / (double)months;

                DateTime dueDate = contract.Date.AddMonths(i + 1);
                amount = _paymentService.Interest(amount, i + 1);
                amount = _paymentService.PaymentFee(amount);

                Installment installment = new Installment(dueDate, amount);
                contract.AddInstallment(installment);
            }
        }
    }
}
