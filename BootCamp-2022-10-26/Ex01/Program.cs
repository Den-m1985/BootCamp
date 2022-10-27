// Быстрая сортировка.


int [] array = {0,2,3,5,-2,10,356,-2158};
int [] res = QuickSort(array, 0, array.Length - 1);
Console.WriteLine("Sotr array: " + "[" + string.Join(" ", res) + "]");


int [] QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return inputArray;
    int pivod = GetPivedIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivod-1);
    QuickSort(inputArray, pivod+1, maxIndex);

    return inputArray;
}

int GetPivedIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivodIndex = minIndex-1;
    for (int i = minIndex; i < maxIndex-1; i++)
    {
        if (inputArray[i]< inputArray[maxIndex])
        {
            pivodIndex++;
            Swap(inputArray, i, pivodIndex);
        }
    }
    pivodIndex++;
    Swap(inputArray, pivodIndex, maxIndex);
    return pivodIndex;
}

void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}