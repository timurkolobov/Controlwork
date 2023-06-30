using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();

        // Разделяем строку на элементы массива
        string[] strings = input.Split(',');

        // Создаем новый массив, в котором будем хранить строки длиной меньше или равной 3 символам
        string[] shortStrings = new string[strings.Length];
        int count = 0;

        // Проходим по каждой строке из исходного массива
        for (int i = 0; i < strings.Length; i++)
        {
            // Проверяем длину строки
            if (strings[i].Length <= 3)
            {
                shortStrings[count] = strings[i];
                count++;
            }
        }

        // Создаем новый массив, с размером, соответствующим количеству строк длиной меньше или равной 3 символам
        string[] result = new string[count];
        Array.Copy(shortStrings, result, count);

        // Выводим полученный новый массив
        Console.WriteLine("Результат:");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine();
    }
}