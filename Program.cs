string str;
Console.WriteLine("Input x for calculation: ");

int x, y;

str = Console.ReadLine();
x = Convert.ToInt32(str);

Console.WriteLine("Input y for calculation: ");
str = Console.ReadLine();
y = Convert.ToInt32(str);

double res1, res2, res3, res4;
res1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
Console.WriteLine("Result of -6*x^3+5*x^2-10*x+15: " + res1);

Console.WriteLine("Press any key to continue.. ");
Console.ReadKey();

res2 = Math.Abs(x) * Math.Sin(x);
Console.WriteLine("Result of abs(x)*sin(x): " + res2);

Console.WriteLine("Press any key to continue.. ");
Console.ReadKey();

res3 = 2 * Math.PI * x;
Console.WriteLine("Result of 2*pi*x: " + res3);

Console.WriteLine("Press any key to continue.. ");
Console.ReadKey();

res4 = Math.Max(x, y);
Console.WriteLine("Result of max(x, y): " + res4);

// New Year
DateTime lastYear = new DateTime(2022,1,1);
DateTime nextYear = new DateTime(2023, 1, 1);

DateTime datenow = DateTime.Today;
Console.WriteLine($"{nextYear-datenow} days left to New Year");
Console.WriteLine($"{datenow-lastYear} days passed from New Year");
//X days left to New Year
//Y days passed from New Year


