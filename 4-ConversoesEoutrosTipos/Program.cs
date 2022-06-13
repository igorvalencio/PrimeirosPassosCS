using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 4 - conversões");

        double salario = 3000.15;
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x = 1000000000000000000;
        Console.WriteLine(x);   
        //long até 64 bits

        short y = 16000;
        Console.WriteLine(y);
        //short até 16 bits

        float altura = 1.91f;
        Console.WriteLine(altura);
    }
}