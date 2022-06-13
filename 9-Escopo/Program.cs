using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando projeto 7 - condicionais");

        int IdadeJoao = 15;
        int QuantidadePessoas = 2;

        bool acompanhado = QuantidadePessoas > 1;
     string TextoAdicional;

       if(acompanhado == true)
        {
            TextoAdicional = "João está acompanhado";
        }
        else
        {
            TextoAdicional = "João não está acompanhado";
        }

        if (IdadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(TextoAdicional);
            Console.WriteLine("pode entrar");
        }
        else
            Console.WriteLine("Não pode entrar");

      


    }
}