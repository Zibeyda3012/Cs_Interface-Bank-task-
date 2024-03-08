namespace Cs_Interface_Bank_task_.Models
{
    public class Operation
    {
        public Guid Id { get; init; }

        public string process_name {  get; init; }

        public DateTime dateTime { get; set; }

        public Operation(string name,DateTime dateTime)
        {
            Id = Guid.NewGuid();
            process_name = name;
            this.dateTime = dateTime;
        }


    }
}
