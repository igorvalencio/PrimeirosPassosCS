using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("ponto flutuante");

        double salario = 8500.52;
        Console.WriteLine(salario);

        double divisao;
        divisao = 7.0 / 5;
        Console.WriteLine(divisao);
        //importante colocar esse .0 pra ele entender que é um double
        //se colocar dois numeros inteiros dentro do double, ele devolve um inteiro, ai perde informação
    }
}


