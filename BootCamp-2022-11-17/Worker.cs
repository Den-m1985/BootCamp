public class T
{
    public T() { }

    public Worker( string fullName, int age, int salary)
    {
        Age = age;
        Salary = salary;
        FullName = fullName;
    }

    public int Id {get; set; }
    public int Age {get; set; }
    public int Salary {get; set; }
    public string FullName {get; set; }

    public override string ToString()
    {
        return $"[{Id} {FullName} {Age} {Salary}]";
    }
}
//Worker w = new Worker("Вася Иванов", 123,12504);
