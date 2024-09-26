using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


        {
          
            {
                while (true)
                {
                    Console.WriteLine("Введіть номер групи елементів (1, 2, 3 або 0 для завершення): ");
                    int group = int.Parse(Console.ReadLine());
                        if (group == 0)
                    {
                        Console.WriteLine("Обчислення завершено.");
                        break;
                    }
                    else if (group == 1)
                    {
                        Console.WriteLine("Введіть основу трикутника: ");
                        double baseTriangle = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть висоту трикутника: ");
                        double height = double.Parse(Console.ReadLine());
                        double area = 0.5 * baseTriangle * height;
                        Console.WriteLine($"Площа трикутника: {area}");
                    }
                    else if (group == 2)
                    {
                        Console.WriteLine("Введіть першу сторону трикутника: ");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть другу сторону трикутника: ");
                        double side2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть кут між сторонами в радіанах: ");
                        double angle = double.Parse(Console.ReadLine());
                        double area = 0.5 * side1 * side2 * Math.Sin(angle);
                        Console.WriteLine($"Площа трикутника: {area}");
                    }
                    else if (group == 3)
                    {
                        Console.WriteLine("Введіть першу сторону трикутника: ");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть другу сторону трикутника: ");
                        double side2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть третю сторону трикутника: ");
                        double side3 = double.Parse(Console.ReadLine());
                        double s = (side1 + side2 + side3) / 2;
                        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
                        Console.WriteLine($"Площа трикутника: {area}");
                    }
                    else
                    {
                     
                            Console.WriteLine("Невірний номер групи. Спробуйте ще раз.");
                           
                            Console.ReadKey();
                        }

                }
            }
        }

    }
}
}
