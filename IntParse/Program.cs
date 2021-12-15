using System;

var input = Console.ReadLine();
if (int.TryParse(input, out var n))
    Console.WriteLine($"Input: {n}");
else
    throw new ArgumentException($"Wrong input '{input}'.");
return;


//var n = 0;

foreach (var ch in input)
{
    if (char.IsDigit(ch))
        n = n * 10 + (ch - '0');
    else
        throw new ArgumentException($"Unexpected character {ch}.");
}

Console.WriteLine($"Input: {n}");
