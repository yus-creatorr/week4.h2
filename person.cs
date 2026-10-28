public class  Person
{

    public string? Name {get;set;}
    public int Age {get;set;}
    public Person(){}
    public Person(string n, int s)
    {
        Name=n;
        Age=s;
    }
    public void Greet()
    {
        System.Console.WriteLine("Helllo");
    }
    public void SetAge(int s)
    {
        Age=s;
    }
}