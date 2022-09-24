// See https://aka.ms/new-console-template for more information
// КИПРОВ ПАВЕЛ 22 ИСП 2/2 ВАРИАНТ 15
try
{
    Console.WriteLine("введите x");
    Console.ForegroundColor = ConsoleColor.Yellow;
    double x =double.Parse(Console.ReadLine());
    double res = 2 * (1/Math.Tan((3 * x)) - 1) / (12 * x * x) + (7 * x) - 5;
    Console.WriteLine($"{res:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}