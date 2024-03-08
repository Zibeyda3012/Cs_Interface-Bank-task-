namespace Cs_Interface_Bank_task_.Models
{
    public class Bank
    {
        public string Name { get; set; }
        public int budget { get; set; }

        public int profit { get; set; }

        public CEO ceo { get; set; }

        public Bank(string name,int budget,int profit)
        {
            this.Name = name;
            this.budget = budget;
            this.profit= profit;
        }

        public List<Worker> workers { get; set; }

        public List<Manager> managers { get; set; }

        public List<Client> clients { get; set; }

        public void CalculateProfit()
        {
            Console.WriteLine("calculate profit");
        }

        public void ShowClientCredit(string name, string surname)
        {
            foreach (var client in clients)
                if (client.name == name && client.surname == surname)
                    Console.WriteLine(client.myCredit.ToString());
        }

        public void PayCredit(Client client,double money)
        {
            Console.WriteLine("Pay credit");
        }

        public void ShowAllCredit()
        {
            foreach(var client in clients)
                Console.WriteLine(client.myCredit.ToString());
        }

    }
}