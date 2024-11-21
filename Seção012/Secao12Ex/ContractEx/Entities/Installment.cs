
using System.Globalization;


namespace ContractEx.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount){
            DueDate = dueDate;
            Amount = amount;
        }

        override public string ToString(){
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}