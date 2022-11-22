
//Worker w = new Worker(123, 4568, "Вася Иванов");

//Console.WriteLine(w);
//System.Console.WriteLine(w.Salary);
//System.Console.WriteLine(w.FullName);

App<Worker> app = new App<Worker>(new ListRepository<>());

app.Create(new("Василий Иванов", 22, 2564));
app.Create(new("Иван Петров", 242, 2563454));
app.Create(new("Василий Кузнецов", 22985, 25644));

app.Print(); Console.WriteLine();

