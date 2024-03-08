using Cs_Interface_Bank_task_.Interfaces;

namespace Cs_Interface_Bank_task_.Models
{
    public class CEO : IPerson, ISystem
    {
        public Guid myId { get; init; }
        public string name { get; set; }
        public string surname { get; set; }

        public string position { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
        public CEO(string name, string surname, int age, string position, int salary)
        {
            myId = Guid.NewGuid();
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.position = position;
            this.salary = salary;
        }

        public void Organize()
        {
            Console.WriteLine("CEO organizes");
        }

        public void Control()
        {
            Console.WriteLine("CEO controls");
        }

        public void makeMeeting()
        {
            Console.WriteLine("CEO makes meetings");
        }

        public void decreasePercentage(double percent)
        {
            Console.WriteLine("Percentage decreased");
        }
    }
}
