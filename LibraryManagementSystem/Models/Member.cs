public class Member
{
    public int Id {get; set;}
    public string FullName {get; set;} = null!;
    public string Email {get; set;} = null!;
    public string PhoneNumber {get; set;}= null!;
    public DateTime RegistrationDate;
    public List<Borrowing> Borrowings {get; } = new List<Borrowing>();
}