public class Student : Person
{
    public Student()
    {
    }

    public Student(string n, int s) : base(n, s)
    {
    }

    public void Study()
    {
        System.Console.WriteLine("I'm studying");
    }
    public void ShowAge()
    {
        System.Console.WriteLine($"My age is {Age} years old");
    }
}