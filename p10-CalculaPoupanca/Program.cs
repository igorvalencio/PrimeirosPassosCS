using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando projeto 10 - simulação de poupança");

        //para saber o rendimento de 0,5% ao mês tem que fazer vezes 0.005

        double investimento = 1000;
        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);

        int mes = 1;
        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mês " + mes + " você tem R$ " + investimento);
            mes++;

        }



}   }