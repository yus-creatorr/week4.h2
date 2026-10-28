
    public class Boook : AbstractBook, Borrowable
    {
        public void Borrow()
        {
            Console.WriteLine($"Книга '{Title}' была успешно взята в аренду.");
        }

        public void ReturnBook()
        {
            Console.WriteLine($"Книга '{Title}' была возвращена в библиотеку.");
        }
    }
