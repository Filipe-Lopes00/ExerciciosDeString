using System.Security.Cryptography.X509Certificates;
/*3. Desenvolva uma aplicação troque cada letra de um texto por outra do alfabeto X posições a frente, onde X pode
ser escolhido por você (cifra de César)
a. Exemplo com X=2:
b. “DIEGO” passará a ser “FKGIQ”*/


 internal class Program
 {
           static void Main(string[] args)
           {            
                Console.WriteLine("Digite o primeiro texto: ");
                string texto = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                int recebeValor;
                char[] texto2 = texto.ToCharArray(); //converte o texto em casas

                for (int i = 0; i < texto2.Length; i++) 
                {
                    if (texto2[i] !=  ' ') //entende que se tiver espaço ele pula direto pro comando abaixo
                    {
                        recebeValor = (int)texto2[i]; //converte o texto em char para inteiro pra nova variavel criada

                        recebeValor += valor;

                        texto2[i] = (char)recebeValor;
                    }          
                    Console.Write(texto2[i]);

                }
           } 
  }


            
    
       



    
