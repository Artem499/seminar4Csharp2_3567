// Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

class num

    {
        public int x;
        public int y;
    }

// мне первый вариант без цикла нравится больше. Написать его
// проще, быстрее, читается легче.

class math
    {
       static void Main(string[] args)
        {
            Console.Clear();

            num num = new num();
            
            Console.WriteLine("Консольное приложение возводит число X");
            Console.WriteLine("в натуральную степень Y");
            
            Console.WriteLine("\n\tVARIANT 1 : ");
            Console.Write("\nEnter the first number X : ");
            num.x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\nEnter the second number Y : ");
            num.y = Convert.ToInt32(Console.ReadLine());
            
            double result = Math.Pow(num.x, num.y);

            Console.WriteLine($"\n{num.x} в степени {num.y} = {result}");

            Console.WriteLine("\n\tVARIANT 2 : ");
       
            num number = new num();

            Console.WriteLine("\nКонсольное приложение возводит число X");
            Console.WriteLine("в натуральную степень Y");

            Console.Write("\nEnter the first number X : ");
            number.x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\nEnter the second number Y : ");
            number.y = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number.x; i++)
            {
                Console.WriteLine($"\ntable : {i}");

                if (i <= number.x)
                {
                    Console.Write($"otput : {Math.Pow(i, number.y)}");
                }
            Console.WriteLine();
            }
            

        }
    }