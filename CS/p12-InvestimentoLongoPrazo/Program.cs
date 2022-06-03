using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 12 - Investimento longo prazo");

        double FatorRendimento = 1.005;
        double investimento = 1000;
        int mes = 1;
        
        for(int anos = 1;  anos <= 5;  anos++)
        {
            for ( mes = 1;  mes <= 5;  mes++)
            {
                investimento *= FatorRendimento;
            }
        } FatorRendimento += 1.005;
        
        Console.WriteLine("Depois de 5 anos você terá R$" + investimento);
    }
}