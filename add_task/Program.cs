// Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data
// хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива 
//data с учётом информации из массива info.
Console.Clear();
Random random = new Random();
int sizeData = random.Next(4, 11);
int[] data = new int[sizeData];
FillArray(data, 1, 10);
int sizeInfo = 0;
for (int i = 0; i < sizeData; i++)
{
    sizeInfo += data[i];
}

int[] info = new int[sizeInfo];
FillArray(info, 0, 1);
PrintArray(data);
PrintArray(info);
int bias = 0;
for (int i = 0; i < data.Length; i++)
{
    string numberStr = "";
    for (int j = 0; j < data[i]; j++)
    {
        numberStr += info[j + bias];
    }
    int number = Convert.ToInt32(numberStr);
    Console.Write(number + " -> ");
    int result = ConvertFromBin(number, numberStr.Length);
    Console.WriteLine(result);
    bias += data[i];
}
int ConvertFromBin(int number, int length)
{
    int result = 0;
    for (int j = 0; j < length; j++)
    {
        result += number % 10 * PowerOfTwo(j);
        number /= 10;
    }
    return result;
} 

int PowerOfTwo(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= 2;
    return result;

}

void FillArray(int[] num, int minValue = 0, int maxValue = 150)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] num)

{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}