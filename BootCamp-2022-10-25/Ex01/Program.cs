// Сортировка пузырьком

int[] array1 = { 1, 3, 5, 9, 7, 2, 0, 2, 6, 45, 7, 9 };
Console.WriteLine("Start array:  [" + string.Join(" ", array1) + "]");
int size1 = array1.Length;
for (int i = 0; i < size1; i++)
{
    for (int j = 0; j < size1 - 1; j++)
    {
        int temp = 0;
        if (array1[j] > array1[j + 1])
        {
            temp = array1[j];
            array1[j] = array1[j + 1];
            array1[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(" ", array1) + "]");
}
Console.WriteLine("Finish array: [" + string.Join(" ", array1) + "]");
