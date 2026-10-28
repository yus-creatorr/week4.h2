public class Teacher : Person
{
    public Teacher()
    {
    }

    public Teacher(string n, int s) : base(n, s)
    {
    }
    public void Explain()
    {
        System.Console.WriteLine("I'm explaining");
    }
}