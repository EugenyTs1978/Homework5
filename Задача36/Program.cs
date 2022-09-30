/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
*/
 int[] CreateArray(int length, int startPoint,int endPoint)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(startPoint, endPoint);
    }
    return array;
}
int SumOfOddNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int[] userArray = CreateArray(10,1,10);
int isSum = SumOfOddNumbers(userArray);
PrintArray(userArray);
Console.Write($"Сумма элементов, стоящих на нечётных позициях в массиве равна {isSum}");
