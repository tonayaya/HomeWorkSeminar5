// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами: ");
int[] FillArray1()
{
    int[] arr = new int[4];
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i]=new Random().Next(100,1000);
    }
    return arr;
}

int Search2(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
        count ++;
        }
    }
return count;
}
int[]NewArr1 = FillArray1();
System.Console.WriteLine($"[{string.Join(", ", NewArr1)}]");
System.Console.WriteLine(Search2(NewArr1));
