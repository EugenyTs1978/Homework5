/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/
 double[] CreateArray(int length, double startPoint, double endPoint)
{
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (endPoint -startPoint) + startPoint, 2);
    }
    return array;
}
double RangeOfArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return Math.Round(max - min, 2);
}
void PrintArray(double[] array)
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
double[] userArray = CreateArray(10,-10,10);
double isRange = RangeOfArray(userArray);
PrintArray(userArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {isRange}");
