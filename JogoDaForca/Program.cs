using System;

namespace JogoDaForca
{
    internal class Program
    {
        static string[] palavraAleatoria = {"ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "ABACATE", "BACABA", "BACURI", "BANANA",
            "CAJA", "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA",
            "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };
        static int cont = 5;        
        static char[] palavra = gerarPalavraAleatoria().ToCharArray();
        static char[] tracos = new char[palavra.Length];
        static char letra;
        static Boolean finalizou = false;
        static void Main(string[] args)
        {            
            criarInterface();
            criarPalavraInterface();
            while (cont > 0)
            {
                lerLetra();
                if (finalizou)
                {
                    Console.WriteLine("\nParabéns você acertou a palavra!!");
                    break;
                }
            }
         }

        static string gerarPalavraAleatoria()
        {
            Random random = new Random();
            int posicaoPalavra = random.Next(palavraAleatoria.Length);

            string palavra = palavraAleatoria[posicaoPalavra];
            return palavra;
        }
        static void criarInterface()
        {
            if (cont == 5)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("|/              |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|------");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if(cont == 4) 
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("|/              |");
                Console.WriteLine("|               0");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|------");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (cont == 3)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("|/              |");
                Console.WriteLine("|               0");
                Console.WriteLine("|               x");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|------");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (cont == 2)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("|/              |");
                Console.WriteLine("|               0");
                Console.WriteLine("|               x");
                Console.WriteLine("|               x");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|------");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (cont == 1)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("|/              |");
                Console.WriteLine("|               0");
                Console.WriteLine("|              |x|");
                Console.WriteLine("|               x");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|------");
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("|/              |");
                Console.WriteLine("|               0");
                Console.WriteLine("|              |x|");
                Console.WriteLine("|               x");
                Console.WriteLine("|              | |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.Write("|------ \n SEU BONECO MORREU\n A PALAVRA ERA: ");
                for (int i = 0; i < palavra.Length; i++)
                {
                    Console.Write(palavra[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static void criarPalavraInterface()
        {
            for (int i = 0; i < tracos.Length; i++)
            {
                tracos[i] = '-';
                Console.Write(tracos[i]);
            }
        }
        static void criaPalavraDps()
        {
            for (int i = 0; i < tracos.Length; i++)
            {
                Console.Write(tracos[i]);
            }
        }
        static void verificarLetra()
        {
            Boolean achouLetra = false;            
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    tracos[i] = letra;
                    achouLetra = true;
                }                
            }
            if(achouLetra == false)            
                cont--;            
            for (int i = 0;i < palavra.Length; i++)
            {
                if (palavra[i] == tracos[i])                
                    finalizou = true;                
                else
                {
                    finalizou = false;
                    break;
                }
            }
        }
        static void lerLetra()
        {
            Console.WriteLine("\nVoce tem " + cont + " chances\nDigite uma letra: ");
            letra = char.Parse(Console.ReadLine());
            Console.Clear();            
            verificarLetra();
            criarInterface();
            criaPalavraDps();
        }
    }
}