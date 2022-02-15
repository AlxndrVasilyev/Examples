int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// ниже номера индексов в массиве 
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };
array[0] = 12;
Console.WriteLine(array[4]);

int maximum = Max(
    Max(array[0], Max(array[1], Max(array[2]),
    Max(array[3], Max(array[4], Max(array[5]),
    Max(array[6], Max(array[7], Max(array[8]);

Console.WriteLine(maximum);
