

using ContractEx.Entities;
using Microsoft.VisualBasic;

namespace ContractEx.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double value = (double)contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double interest = value + _onlinePaymentService.Interest(value, i);
                double totalPayment = interest + _onlinePaymentService.PaymentFee(interest);
                contract.AddInstallment(new Installment(date,totalPayment));
            }
        }
    }
}