using System;
using ExtandedCalculator;


namespace ExtandedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string again = "T";
            while (again == "T")
            {
                PrintMenu();
                Calc();
                Console.WriteLine("Wykonać ponownie?(T/N)");
                again = Console.ReadLine().ToUpper();
                Console.Clear();
            }

        }

        public static void PrintMenu()
        {
            Console.WriteLine("Witaj w kalkulatorze");
            Console.WriteLine("Co chesz zrobić?");
            Console.WriteLine("\t1 - Wykonać dodawanie");
            Console.WriteLine("\t2 - Wykonać odejmowanie");
            Console.WriteLine("\t3 - Wykonać mnożenie");
            Console.WriteLine("\t4 - Wykonać dzielenie");
            Console.WriteLine("\t5 - Wykonać potęgowanie");
            Console.WriteLine("\t6 - Sprawdzić parzystość");
            Console.WriteLine("\t7 - Obliczyć silnię");
            Console.WriteLine("\t8 - Obliczyć sumę poprzednich liczb");

        }

        public static void Calc()
        {
            Console.WriteLine("Klawisz menu");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice <= 5)
            {
                Console.WriteLine("Podaj pierwszą liczbę");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj drugą");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Operations operations = new Operations(num1, num2);
                string printScore = "Wynik działania to: ";
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(printScore + operations.AddNumbers());
                        break;
                    case 2:
                        Console.WriteLine(printScore + operations.SubtractNumbers());
                        break;
                    case 3:
                        Console.WriteLine(printScore + operations.MultiplicateNumbers());
                        break;
                    case 4:
                        Console.WriteLine(printScore + operations.DivideNumbers());
                        break;
                    case 5:
                        Console.WriteLine(printScore + operations.Power());
                        break;
                    default:
                        break;
                }
            }
            else if(choice <=8)
            {
                {
                    Console.WriteLine("Podaj liczbę");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Operations operations = new Operations(num1);
                    string printScore = "Wynik operacji to: ";
                    switch (choice)
                    {
                        case 6:
                            Console.WriteLine(printScore + operations.IsNumberEven());
                            break;
                        case 7:
                            Console.WriteLine(printScore + operations.Silnia());
                            break;
                        case 8:
                            Console.WriteLine(printScore + operations.Sum());
                            break;
                        default:
                            break;
                    }
                }
            }


            else
            {
                Console.WriteLine("Wciśnięto błędny klawisz, proszę spróbować ponownie");
                Calc();
            }

        }


    }



}