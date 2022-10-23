// Бинарный поиск.
//y = log(n)

#region y = log(n)
int BinarnySearch(int[] array, int find)
{
    int left = 0;
    int right = array.Length - 1;
    while (left <= right)
    {
        int midle = (left + right)/2;
        if (find == array[midle]) return midle;
        else if (find < array[midle]) right = midle - 1;
        else left = midle +1;
    }
    return -1;
}
