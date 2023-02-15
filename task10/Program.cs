internal class Program
{
    private static void Main(string[] args)
    {
        int Prompt(string message, string? value)
        {
            Console.Write(message);
            int result = Convert.ToInt32(value);
            return result;
        }

        int number = Prompt("Введите трёхзначное число > ", Console.ReadLine());
        if (number < 100 || number >= 1000)
        {
            Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста повторите ввод");
            return;
        }
        Console.WriteLine($"Введённое число `{number}`");
        int secondRank = number / 10 % 10;
        Console.WriteLine($"Вторая цифра `{secondRank}`");
    }
}