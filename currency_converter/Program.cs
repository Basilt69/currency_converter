using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromCurrency;
            string toCurrency;
            double amount = 1;
            float euroRate = 0;
            float usdRate = 0;
            float gbpRate = 0;
            double exchangeRate;

            //
            // Выведение информации о допустимых для конвертации валют.
            //

            // Get all available currency tags
            string[] availableCurrency = new [] {"EUR", "USD", "GBP"};
            // Print currency tags comma seperated
            Console.WriteLine("Настоящая программа позволяет конвертировать следующие валюты");
            Console.WriteLine(string.Join(",", availableCurrency));
            Console.WriteLine("\n");

            //
            // запрос о введении курсов валют для USD, EUR, GBP по отношению к рублю
            //
            Console.WriteLine("Введите курс валют:");
            Console.WriteLine("EUR / RUB");
            euroRate = float.Parse(Console.ReadLine());
            Console.WriteLine("USD / RUB");
            usdRate = float.Parse(Console.ReadLine());
            Console.WriteLine("GBP / RUB");
            gbpRate = float.Parse(Console.ReadLine());
            
            // Запрос начальной и целевой валюты для конвертации

            Console.WriteLine("Введите валюту из которой Вы бы хотели конвертировать:");
            fromCurrency = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Введите валюту в которую Вы бы хотели конвертировать");
            toCurrency = Console.ReadLine();
            Console.WriteLine("\n");
            
            Console.WriteLine("Введите сумму для конвертации");
            amount = double.Parse(Console.ReadLine()); 

            //
            // Вычисления
            //

            // Calls a method to get the exchange rate between 2 currencies
            if (fromCurrency == "eur" && toCurrency == "rub")
            {
                exchangeRate = euroRate * amount;
                Console.WriteLine($"{fromCurrency} равно {exchangeRate} RUB", fromCurrency, exchangeRate);
                
            }
            else if (fromCurrency == "rub" && toCurrency == "eur")
            {
                exchangeRate = amount / euroRate;
                Console.WriteLine($"{fromCurrency} равно {exchangeRate} EUR", fromCurrency, exchangeRate);
                
            }
            else if (fromCurrency == "usd" && toCurrency == "rub")
            {
                exchangeRate = usdRate * amount;
                Console.WriteLine($"{fromCurrency} равно {exchangeRate} RUB", fromCurrency, exchangeRate);
                
            }
            else if (fromCurrency == "rub" && toCurrency == "usd")
            {
                exchangeRate = amount / usdRate;
                Console.WriteLine($"{fromCurrency} равно {exchangeRate} USD", fromCurrency, exchangeRate);
                
            }
            else if (fromCurrency == "gbp" && toCurrency == "rub")
            {
                exchangeRate = gbpRate * amount;
                Console.WriteLine($"{fromCurrency} равно {exchangeRate} RUB", fromCurrency, exchangeRate);
                
            }
            else if (fromCurrency == "rub" && toCurrency == "gbp")
            {
                exchangeRate = amount / usdRate;
                Console.WriteLine($"{fromCurrency} равно {exchangeRate} GBP", fromCurrency, exchangeRate);
                
            }
            ;
        }
    }
}