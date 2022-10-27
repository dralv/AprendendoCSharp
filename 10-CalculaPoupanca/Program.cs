using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 10");

        double investimento = 1000;
        int mes = 1;
        /*
        while(mes <= 12){
            investimento  = investimento + investimento* 0.005;
            Console.WriteLine(investimento);
            mes++;
        }
        */
        
        for (int i = 1; i <= 12; i++)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
        }
        

    }
}