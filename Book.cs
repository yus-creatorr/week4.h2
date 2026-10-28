public class Book
{
    public string Title{get;set;}=null!;
    public string Autor{get;set;}=null!;
    public int PublishedYear;
    public Book(){}
    public Book(string ti, string au, int pu)
    {
        Title = ti;
        Autor=au;
        PublishedYear=pu;
    }

}