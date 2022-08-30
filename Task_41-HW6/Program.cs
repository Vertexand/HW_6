// homework 6 № 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.  0, 7, 8, -2, -2 -> 2  1, -7, 567, 89, 223-> 3 



Console.Write("Введите произвольно числа через пробел: ");
string str = Console.ReadLine();
string[] arrStr = str.Split();
int[] numbers = arrStr.Select(int.Parse).ToArray(); //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine($"Всего чисел больше 0: {count}");

// вар-т цикл - запрос к пользов сколько будет цифр М /18.51 lec 7

// string str = "1 2 3 4 5 6"; // работает
// string []arrStr = str.Split();
// Console.WriteLine(string.Join(", ", arrStr));

// string str = Console.ReadLine();// работает
// string[] arrStr = str.Split();// Split расколоть
// int[] numbers = arrStr.Select(int.Parse).ToArray();//Выбирать Разобрать
// Console.WriteLine(string.Join(", ", numbers));//Join соединять

// int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();// НЕ РАБОТАЕТ!!? /25.23 lec 7
// Console.WriteLine(string.Join(", ", numbers));  