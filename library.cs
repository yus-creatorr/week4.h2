public class Library
{
    public string Name{get;set;}=null!;
    List<Book> Books = new List<Book>();
    public Library(){}   
    public Library(string a)
    {
        Name = a;
    }   
    
    public void AddBook(Book book)
    {
        Books.Add(book);
    } 
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }
    public Book SearchBook(string t)
    {
         return Books.Find(x=>x.Title==t) ; 
    }
}  