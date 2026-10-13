public class Book
{
    public int Id {get; set;}
    public string Title {get; set;} = null!;
    public string ISBN {get; set;} = null!;
    public DateTime PublishedYear {get; set;}
    public decimal Price {get; set;}
    public int AuthorId {get; set;}
    public int CategoryId {get; set;}
    public Author Author {get; set;} = null!;
    public Category Category {get; set;} = null!;
    public List<Borrowing> Borrowings {get; } = new List<Borrowing>();

}