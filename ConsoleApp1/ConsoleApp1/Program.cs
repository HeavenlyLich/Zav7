using System;

public class Program
{
    //для завдання 13
    public enum InputSymbol  
    {
        Y = 'Y',
        y = 'y',
        N = 'N',
        n = 'n'
    }
    //для завдання 9
    public enum Currency
    {
        USD,
        EUR,
        RUB
    }
    public static void Main()

        //для завдання 13
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Завдання 13");
        while (true)
        {
            Console.Write("Введіть символ (або введіть 'q' для виходу): ");
            char inputChar = Console.ReadKey().KeyChar; /*char для зберігання одного символу */ 
            Console.WriteLine();

            //якщо натиснути q, то завершиться виконання 

            if (inputChar == 'q')
                break;

            if (Enum.IsDefined(typeof(InputSymbol), (int)inputChar)) //перевірка чи inputChar валідне значення 
            {
                InputSymbol symbol = (InputSymbol)inputChar;

                if (symbol == InputSymbol.Y || symbol == InputSymbol.y)
                    Console.WriteLine("Yes");
                else if (symbol == InputSymbol.N || symbol == InputSymbol.n)
                    Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Don't know");
            }
        }
        //для завдання 9
        Console.WriteLine("Завдання 9");
        Console.Write("Введіть суму в гривнях: ");
        double amountInUah = double.Parse(Console.ReadLine());

        double amountInUsd = ConvertCurrency(amountInUah, Currency.USD);
        double amountInEur = ConvertCurrency(amountInUah, Currency.EUR);
        double amountInRub = ConvertCurrency(amountInUah, Currency.RUB);

        Console.WriteLine($"Сума в доларах: {amountInUsd} USD");
        Console.WriteLine($"Сума в євро: {amountInEur} EUR");
        Console.WriteLine($"Сума в рублях: {amountInRub} RUB");
    }
    //створюю конвертацію валют
    public static double ConvertCurrency(double amount, Currency targetCurrency)
    {
        switch (targetCurrency)
        {
            case Currency.USD:
                return amount * 0.027; 
            case Currency.EUR:
                return amount * 0.025; 
            case Currency.RUB:
                return amount * 2.16; 
            default:
                throw new ArgumentException("Виникла помилка");
        }
    }
}
