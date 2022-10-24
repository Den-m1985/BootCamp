// Делаем таблицу умножения.

int n = Convert.ToInt32(Console.ReadLine());

DateTime dtStart = DateTime.Now;

//Линейная сложность.
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i*j);
        Console.Write("\t");
    }
    Console.WriteLine();
}
DateTime dtEnd = DateTime.Now;
Console.WriteLine((dtEnd - dtStart).TotalMilliseconds);
Console.WriteLine();



DateTime dtStart2 = DateTime.Now;

//Квадратичная сложность.
int[,] matrix = new int [n,n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = (i + 1) * (j + 1);
        matrix[j,i] = (i + 1) * (j + 1);
        Console.Write(matrix[i,j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}

 
DateTime dtEnd2 = DateTime.Now;
Console.WriteLine((dtEnd2 - dtStart2).TotalMilliseconds);


// Если n = 5  2й метод быстрее на 97%
// Если n = 10  2й метод быстрее на 45%
// Если n = 15  2й метод быстрее на 68%