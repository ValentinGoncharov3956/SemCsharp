// int a = 67;
// char b = (char)a;
// System.Console.WriteLine(b);

// void List(list<string> list )
// {

// }


double number = Random.Shared.NextDouble() * 1000 - 100;  // [0.0, 1.0)
double[] doubles = new double[] {2.1234324, 1.234231541241, 532.525254};
System.Console.WriteLine($"{string.Join(", ", doubles.Select(x=> Math.Round(x, 2)))}");
System.Console.WriteLine($"{number:f0}");

