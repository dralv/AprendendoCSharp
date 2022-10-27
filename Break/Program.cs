using System;

public class OlaMundo
{
    static void Main(string[] args)
    {
        string desenho = "*";
        for(int contadorLinhas  = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for(int contadorColunas = 0;contadorColunas<10;contadorColunas++)
            {

                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }
    }
}
