using System;


namespace ExtandedCalculator
{
    public class Operations
    {
        public Operations(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public Operations(double num1)
        {
            Num1 = num1;
        }

        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double AddNumbers()
        {
            return Num1 + Num2;
        }
        public double SubtractNumbers()
        {
            return Num1 - Num2;
        }
        public double MultiplicateNumbers()
        {
            return Num1 * Num2;
        }
        public double DivideNumbers()
        {
            double divide;


            while (Num2 == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0! Proszę spróbować ponownie");
                break;
            }
            divide = Num1 / Num2;


            return divide;

        }
        public int Silnia()
        {
            int silnia = 1;
            for (int i = 1; i <= Num1; i++)
                silnia *= i;
            return silnia;
        }
        public string IsNumberEven()
        {
            string even;
            if (Num1 % 2 == 0)
            {
                even = "Podana liczba jest parzysta";
            }
            else even = "Podana liczba jest nieparzysta";
            return even;
        }
        public double Power()
        {
            double power = Math.Pow(Num1, Num2);
            return power;

        }

        public double Sum()
        {
            double sum = (Num1 * (Num1 + 1)) / 2;
            return sum;

        }
    }
}