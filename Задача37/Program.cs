/*Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
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
int[] NewArray(int[] array)
{   
    int newLength = 0;
    if(array.Length % 2 == 0)
    {
        newLength = array.Length/2;
    }
    else
    {
        newLength = array.Length/2  + 1;
    }
    int[] newarray = new int[newLength];
    for(int i = 0; i < newLength; i++)
    {
        newarray[i] = array[i] * array[array.Length - 1 - i];
        if(array.Length % 2 != 0)
        {
            newarray[newLength - 1] = array[newLength - 1];
        } 
    }
    return newarray;
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
Console.WriteLine("Введите длину массива");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateArray(userSize,-10,10);
int[] userNewArray = NewArray(userArray);
PrintArray(userArray);
PrintArray(userNewArray);


