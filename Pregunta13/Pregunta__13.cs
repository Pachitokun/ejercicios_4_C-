// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var (valor1, valor2, valor3) = (true, true, false);


bool ResultAnd= valor1 && valor2 && valor3;
Console.WriteLine(ResultAnd); //Verdadero


bool ResultOr = valor1 || valor2 || valor3;
Console.WriteLine(ResultOr); //Verdadero

bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);