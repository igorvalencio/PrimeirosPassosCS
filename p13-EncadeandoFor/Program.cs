using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 13 - encadeando for");

        //com break
        for (int ContadorLinhas = 0; ContadorLinhas < 10; ContadorLinhas++)
        {
            for (int ContadorColuna = 0; ContadorColuna < 10; ContadorColuna++)
            {
                Console.Write("*");
                if (ContadorColuna >= ContadorLinhas)
                    break;

                
            }
            Console.WriteLine();
        }

        //sem break
        for(int ContadorLinhas = 0; ContadorLinhas < 10; ContadorLinhas++)
        {
            for (int ContadorColuna = 0; ContadorColuna <= ContadorLinhas ; ContadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}