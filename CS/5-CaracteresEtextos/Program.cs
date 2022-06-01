using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 5 - caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);
        //letras são representadas por numeros tambem.. pesquisar no site ascii table 

        letra = (char)(65 + 4);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Curso de Cs ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        //podemos ter string vazia
        //não podemos ter char vazio

        string cursos =@"-Python 
-JAVA 
-CS 
-HTML";

        Console.WriteLine(cursos);
        //pra deixar um embaixo do outro, colocar @ antes de mencionar a string        



    }
}