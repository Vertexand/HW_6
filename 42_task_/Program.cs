// // // Задача 42: Напишите программу, которая будет преобразовывать десятичное
// // число в двоичное.  45 -> 101101 // 3 -> 11 // 2 -> 10

// int n = Convert.ToInt32(Console.ReadLine());//сама
// int N = 
// void GetBinaryView
// GetBinaryView(N);//ВЫЗЫВ ЭТУ ФУНКЦ
// {
//     if (number <=0) return;
//     GetBinaryView(number /2);
//     Console.WriteLine(number /2);
//     {
        
//     }
// }

Console.WriteLine("Введите число");//иван
int N = Convert.ToInt32(Console.ReadLine());
GetBinaryView(N);

void GetBinaryView(int number)
{
    if (number <= 0) return;
    GetBinaryView(number / 2);
    Console.Write(number % 2);
}

Console.WriteLine("Введите число");// pfl 42 даша
int n = Convert.ToInt32(Console.ReadLine());
int[] b = new int[];
for (int i = 0; n > 0; i++){
    b[i] = n %2;
    n = n /2;
}
 Console.WriteLine($" [{string.Join(", ", b)}]");


// const int ARRAY_SIZE = 6;// pfl 39
// const int LEFT_RANGE = -10;
// const int RIGHT_RANGE = 10;

// int[] array = FillArrayWithRandomNumbers(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
// Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");
// ReverseArray(array);
// Console.WriteLine($"Перевернутый массив: {string.Join(", ", array)}");

// //метод возвращает массив на size элементов
// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];

//     Random random = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(leftRange, rightRange + 1);
//     }

//     return array;
// }

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }