using System;

namespace converter
{
    class Converter
    {
        public Converter(double eur, double usd)
        {
            _eur = eur;
            _usd = usd;
        }
        public double HrnToEur(double hrn)
        {
            if (_eur != 0)
            {
                return Math.Round( hrn / _eur, 2);
            }
            else
            {
                Console.WriteLine("*ERROR* Divide by zero");
                System.Environment.Exit(0);
                return 0;
            }
        }
        public double HrnToUsd(double hrn)
        {
            if (_usd != 0)
            {
                return Math.Round(hrn/_usd, 2);
            }
            else
            {
                Console.WriteLine("*ERROR* Divide by zero");
                System.Environment.Exit(0);
                return 0;
            }
        }
        public double EurToHrn(double eur)
        {
                return eur * _eur;
        }
        public double UsdToHrn(double usd)
        {
                return usd * _usd;
        }

        private double _eur = 0.0;
        private double _usd = 0.0;

    }
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            string first;
            string second;
            double amount;
            Console.WriteLine("Enter current exchange rate:\n");
            Console.WriteLine("USD: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("EUR: ");
            b = Convert.ToDouble(Console.ReadLine());
            Converter con = new Converter(b, a);
            Console.WriteLine("What currency do you have? (Type h for HRN, u for USD, e for EUR)\n");
            first = Console.ReadLine();
            Console.WriteLine("What amount do you have? (Type double)\n");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what currency you want to convert to? (Type h for HRN, u for USD, e for EUR)\n");
            second = Console.ReadLine();
            Converter Con = new Converter(a, b);
            if(first==second) Console.WriteLine($"Converted amount: {amount}");
            switch (first)
            {
                case "h":
                    switch (second)
                    {
                        case "e":
                            Console.WriteLine($"Converted amount: {con.HrnToEur(amount)}");
                            break;
                        case "u":
                            Console.WriteLine($"Converted amount: {con.HrnToUsd(amount)}");
                            break;
                    }
                break;
                case "u":
                    switch (second)
                    {
                        case "e":
                            Console.WriteLine($"Converted amount: {con.HrnToEur(con.UsdToHrn(amount))}");
                            break;
                        case "h":
                            Console.WriteLine($"Converted amount: {con.UsdToHrn(amount)}");
                            break;
                    }
                break;
                case "e":
                    switch (second)
                    {
                        case "h":
                            Console.WriteLine($"Converted amount: {con.EurToHrn(amount)}");
                            break;
                        case "u":
                            Console.WriteLine($"Converted amount: {con.HrnToUsd(con.EurToHrn(amount))}");
                            break;
                    }
                break;
            }
        }
    }
}