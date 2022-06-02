using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando projeto 7 - condicionais");

        int IdadeJoao = 16;
        int QuantidadePessoas = 3;

        if (IdadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if(QuantidadePessoas>=2)
            {
                Console.WriteLine("Pode entrar porque está acompanhado");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
            
        }
    }
}