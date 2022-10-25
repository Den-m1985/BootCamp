// сортировка
int n = 5;
int[] array = new int[n];

DateTime dtStart = DateTime.Now;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1,20);
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(" ", array) + "]");

//Сортировка
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] < array[minIndex]) minIndex = j;
    }
    int temp;
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(" ", array) + "]");

DateTime dtEnd = DateTime.Now;
Console.Write("Speed: ");
Console.WriteLine((dtEnd - dtStart).TotalMilliseconds);



int size = 5;
string [] array2 = new string [size];
for (int i = 0; i < size; i++)
{
    array2[i] = Console.ReadLine();
}
Console.WriteLine("[" + string.Join(" ", array2) + "]");
//Сортировка
for (int i = 0; i < size - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < size; j++)
    {
        if (array2[j].Length < array2[minIndex].Length) minIndex = j;
    }
    string temp;
    temp = array2[minIndex];
    array2[minIndex] = array2[i];
    array2[i] = temp;
}
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(" ", array2) + "]");