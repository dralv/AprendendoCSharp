using System;

public class OlaMundo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 15;
        int qtdPessoas = 2;

        bool acompanhado = qtdPessoas > 0;
       
        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar");
        }
        else 
        {
            Console.WriteLine("Não pode entrar");
        }
    }
}