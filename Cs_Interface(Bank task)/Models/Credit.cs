using System.Xml;

namespace Cs_Interface_Bank_task_.Models
{
    public class Credit
    {
        public Guid Id { get; init; }
        public double amount {  get; set; }

        public double percent {  get; set; }

        public int months {  get; set; }

        public Credit(double amount,double percent,int months)
        {
            Id = new Guid();
            this.amount = amount;
            this.percent = percent;
            this.months = months;
        }

        public void calculatePayment()
        {
            Console.WriteLine("Calculating monthly payment");
        }

        public void CalculatePercent()
        {
            Console.WriteLine("calculating percentage");
        }

        public override string ToString()
        {
            return $"Credit Id: {Id} \nAmount: {amount} \nPercent: {percent} \n Months: {months}\n\n";
        }
    }
}
