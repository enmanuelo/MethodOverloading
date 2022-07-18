using MethodOverloading;

var sumInteger = Methods.Add(2, 3);
Console.WriteLine(sumInteger);

var sumDecimal = Methods.Add(0.13m, 1.3m);
Console.WriteLine(sumDecimal);

var sumDollar = Methods.Add(2, 3, true);
Console.WriteLine(sumDollar);