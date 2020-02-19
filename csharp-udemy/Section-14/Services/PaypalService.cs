using System;

namespace Section14.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        public PaypalService()
        {
        }

        public double PaymentFee(double amount)
        {
            return amount * 1.02;
        }

        public double Interest(double amount, int months)
        {
            return amount * (1 + (months * 0.01));
        }
    }
}
