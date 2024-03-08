using Cs_Interface_Bank_task_.Interfaces;
using System.ComponentModel;

namespace Cs_Interface_Bank_task_.Models
{
    public class Worker : IPerson, ISystem
    {
        public Guid myId { get; init; }
        public string name { get; set; }
        public string surname { get; set; }

        public string position { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }

        public List<Operation> operations { get; set; }
        public Worker(string name, string surname, int age, string position, int salary, DateTime start_time, DateTime end_time)
        {
            myId = Guid.NewGuid();
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.position = position;
            this.salary = salary;
            this.start_time = start_time;
            this.end_time = end_time;
        }

        public void Organize()
        {
            Console.WriteLine("Worker organizes");
        }

        public void addOperation(Operation operation)
        {
            operations.Add(operation);
        }


    }
}
