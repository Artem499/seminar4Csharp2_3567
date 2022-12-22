// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

class array
{
    static void Main(string[] args)
    {
        
        Console.Write(" Enter the elements of the array : ");

        int index = int.Parse(Console.ReadLine()); 
// функция Parse позволяет переводить строку которая состоит из цифр в целое число
// через пременную index задаю нужное колиичество элементов в массиве

        int[] array = new int[index];

// объявляю новый массив с количеством эллементов, которые заданы в переменной index

        for (int i = 0; i < array.Length; i++)

// создаю цикл, который пройдет по всему массиву

        {
// создаю приглашение в консоли для ввода элементов из консоли
            Console.Write($" Enter the {i + 1} element of the array : ");
            array[i] = int.Parse(Console.ReadLine());
        }
// создаю вывод введенных элементов массива через цикл

        Console.WriteLine("\nAnswer : \n");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"otput of an rarray element : {array[i]}");
        }
    }
}