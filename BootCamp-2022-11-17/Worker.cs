public class Worker
{
    public Worker() { }

    public Worker(int age, int salary, int fullName)
    {
        Age = age;
        Salary = salary;
        FullName = fullName;
    }

    public int Id {get; set; }
    public int Age {get; set; }
    public int Salary {get; set; }
    public int FullName {get; set; }

    public override string ToString()
    {
        return $"[{Id} {FullName} {Age} {Salary}]";
    }
}
Worker w = new Worker("Вася Иванов", 123,12504);
