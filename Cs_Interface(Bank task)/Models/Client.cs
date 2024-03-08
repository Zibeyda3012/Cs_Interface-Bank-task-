using Cs_Interface_Bank_task_.Interfaces;
using System.Globalization;

namespace Cs_Interface_Bank_task_.Models
{
    public class Client : IPerson
    {
        public Guid myId { get; init; }
        public string name { get; set; }
        public string surname { get; set; }

        public string live_address {  get; set; }

        public string work_address {  get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public Credit myCredit { get; set; }

        public Client(string name, string surname,int age,string live_address,string work_address,double salary,Credit credit)
        {
            myId = Guid.NewGuid();
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.live_address = live_address;
            this.work_address = work_address;
            this.salary = salary;
            this.myCredit = credit;

        }
    }
}
