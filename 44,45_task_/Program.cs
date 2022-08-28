// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Введите N ");//сама
internal =Convert.ToInt32
void PrintFibToN(int n);

if ( )
{
   Console.Write("0, 1");//начало с 0 1
   neighbour1 = 0;
   neighbour2 = 1;

   for (int i=0; i<n-2;)

   {
    int res=
    Console
   }

}

Console.WriteLine($"0 1,  ");





// Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
// помощью поэлементного копирования.

foreach(int ele) //убрали


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
GetBinaryView(N);

void GetBinaryView(int number)
{
    if (number <= 0) return;
    GetBinaryView(number / 2);
    Console.Write(number % 2);
}