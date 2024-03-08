namespace Cs_Interface_Bank_task_.Interfaces
{
    public interface IPerson
    {
        Guid myId { get; init; }

        string name { get; set; }
        string surname { get; set; }

        int age { get; set; }

        double salary { get; set; }

    }
}
