using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando projeto 7 - condicionais");

        int IdadeJoao = 18;
        int QuantidadePessoas = 1;

        bool acompanhado = QuantidadePessoas > 1;
        bool grupo = true;
        
      

        if (IdadeJoao >= 18 || QuantidadePessoas > 1)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
                Console.WriteLine("Não pode entrar");
        }

        
    }
}