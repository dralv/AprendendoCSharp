using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5");

        char letra = 'a'; //armazenamento de um caracter
        // o compilador entende o char como um número 
        // não pode ser vazia

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char) (65 + 1); // transformando um inteiro em Char
        Console.WriteLine(letra);

        letra = (char)(66 + 1); 
        Console.WriteLine(letra);

        string primeiraFrase = "Alura Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis:
- GO
- C# 
-Python 
-Java";

        Console.WriteLine(cursos);

    }
}