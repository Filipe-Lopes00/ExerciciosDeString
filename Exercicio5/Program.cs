using System.Diagnostics;

internal class Program
{ /*5. Crie um programa em C# que solicite ao usuário que digite uma frase. Em seguida, o programa deve utilizar
métodos da classe string para realizar as seguintes operações:
 Imprimir a frase em letras maiúsculas;
 Imprimir a frase em letras minúsculas;
 Imprimir a quantidade de caracteres da frase;
 Imprimir a primeira palavra da frase;
 Imprimir a última palavra da frase.*/


    private static void Main(string[] args)
    {
        Console.WriteLine("digite a frase: ");
        string frase = Console.ReadLine();
        string primeiraPalavra =frase.Substring(0, frase.IndexOf(' ') + 1);
        string ultimaPalavra = frase.Substring(frase.LastIndexOf(' ') + 1);
        Console.WriteLine("frase em letras maiúsculas: "+ frase.ToUpper());
        Console.WriteLine("frase em letras minúsculas: "+ frase.ToLower());
        Console.WriteLine("quantidade de caracteres da frase: "+frase.Length);
        Console.WriteLine("primeira palavra da frase: " + primeiraPalavra);
        Console.WriteLine("última palavra da frase: "+ ultimaPalavra);
    }
}