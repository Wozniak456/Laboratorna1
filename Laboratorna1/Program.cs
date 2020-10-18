using System;

namespace Laboratorna1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, q, n; double S;   //описуємо змінні

            Console.WriteLine("vvedit b: "); //перший член прогресії
            int.TryParse(Console.ReadLine(), out b); // конвертація з рядкового типу в чисельний і присвоєння змінній
            Console.WriteLine("vvedit q: ");  //знаменник прогресії
            int.TryParse(Console.ReadLine(), out q);
            Console.WriteLine("vvedit n: ");  //кількість членів прогресії
            int.TryParse(Console.ReadLine(), out n);

            S = (b * (Math.Pow(q, n) - 1)) / (q - 1);  // формула для обрахування суми 

            Console.WriteLine("Suma = {0}", S);  //виведення на консоль

            Console.ReadKey();  // затримка екрана
        }
    }
}
