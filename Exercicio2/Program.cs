using System.Security.Cryptography.X509Certificates;

namespace ExerciciosDeString
{
    internal class Program
    {
        static int ContarPalavras(string frase)
        {
            int contador = 0;
            bool dentroDeUmaPalavra = false;

            for (int i = 0; i < frase.Length; i++)
            {
                char caractereAtual = frase[i];

                if (char.IsLetter(caractereAtual))
                {
                    if (!dentroDeUmaPalavra)
                    {
                        dentroDeUmaPalavra = true;
                        contador++;
                    }
                }
                else
                {
                    dentroDeUmaPalavra = false;
                }
            }

            return contador;
        }
        static void Main(string[] args)
        {

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int numeroPalavras = ContarPalavras(frase);

            Console.WriteLine("A frase digitada contém {0} palavras.", numeroPalavras);
        }
            
          
        
    }
}
