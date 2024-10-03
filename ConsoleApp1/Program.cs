try
{
    Console.WriteLine("Введите число t: ");
    int t = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число y: ");
    int y = int.Parse(Console.ReadLine());
    double S = 4.351 * Math.Pow(y, 3) + (2 * t) * (Math.Log10(t)) / (Math.Sqrt(2 * Math.Cos(y) + 4.351));
    Console.WriteLine($"Число S = {S:F2}");
}
catch
{
    Console.WriteLine("Error");
}
