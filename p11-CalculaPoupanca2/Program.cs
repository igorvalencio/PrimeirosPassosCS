using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando projeto 11 - simulação de poupança 2");

        //para saber o rendimento de 0,5% ao mês tem que fazer vezes 0.005


        /* investimento = investimento + investimento * 0.005;
         Console.WriteLine(investimento);

         int mes = 1;
         while (mes <= 12)
         {
             investimento = investimento + investimento * 0.005;
             Console.WriteLine("no mês " + mes + " você tem R$ " + investimento);
             mes++;

         } */

        double investimento = 1000;
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("no mês " + mes + " você tem R$ " + investimento);
            
        }

    }
}