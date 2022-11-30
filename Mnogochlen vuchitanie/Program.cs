﻿// Задача: 
// Написать программу вычитания двух многочленов

// f(x) =  1*x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4+ 16*x^5
// g(x) =  10*x^0 + 11*x^1 + 4*x^2 

int[] vuch(int[] f, int[] g)

{
    int powF = f.Length;
    int powG = g.Length;

    int resultMax = powF;
    int resultMin = powG;

    if (powG > resultMax)
    {
        resultMax = powG;
        resultMin = powF;
    }

    int[] result = new int[resultMax];

    for (int i = 0; i < resultMin; i++)
    {
        result[i] = f[i] - g[i];
    }

    for (int i = resultMin; i < resultMax; i++)
    {
        if (resultMax == powG) result[i] = g[i];
        else result[i] = f[i];
    }
    return result;
}

string Print(int[] f)
{
    string[] pows = { "⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹" };
    string output = String.Empty;
    for (int i = 0; i < f.Length; i++)
    {
        int t = f[i];
        if (f[i] == 0) continue;
        if (f[i] < 0) { output += " - "; }
        else if (i != 0) { output += " + "; }

        if (t < 0) t = -t;
        if (i == 1) { output += $"{t}x"; }
        if (i == 0) { output += $"{t}"; }
        if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x{pows[i]}"; }
    }
    return output;
}
int[] f = { 1, 3, 5, 7, 12, -9, -6, -23 };
int[] g = { 0, 1, -2, -5, 4, 0, 7, 3 };

Console.Write("f = ");
Console.WriteLine(Print(f));
Console.Write("g = ");
Console.WriteLine(Print(g));
int[] s = vuch(f, g);
Console.Write("f-g = ");
Console.WriteLine(Print(s));
System.Console.WriteLine();