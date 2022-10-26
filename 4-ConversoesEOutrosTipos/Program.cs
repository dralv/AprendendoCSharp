using System;

public class OlaMundo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Convertendo Tipos e outros tipos numéricos");
        double salario;
        salario = 3000.15;

        int salarioInteiro;
        salarioInteiro =(int) salario;

        long x;
        x = 200000000000000;

        short y;
        y = 1500;

        float altura = 1.62f;
        
        Console.WriteLine(altura);


        Console.WriteLine(salarioInteiro);
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

        
    }
}
