using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5");

        char letra = 'a'; //armazenamento de um caracter
        // o compilador entende o char como um número 

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char) (65 + 1); // transformando um inteiro em Char
        Console.WriteLine(letra);

        letra = (char)(66 + 1); 
        Console.WriteLine(letra);
    }
}