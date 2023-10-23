// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");




var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd); //Falso

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr); // Verdadero

bool resultNot = !valor1;
Console.WriteLine(resultNot); //Falso
