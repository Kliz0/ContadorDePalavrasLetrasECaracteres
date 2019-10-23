using System;
using System.Linq;

namespace desafioDNIT
{
    class Exercicio
    {
        protected static void Resolucao ()
        {
            Console.WriteLine("Escreva aqui o texto que você quer contar o número de palavras e caracteres, além da contagem de cada letra.");
            string escrito = Console.ReadLine();

            int contadorDeCaracteres = escrito.Length;


            int contadorDePalavras = escrito.Count(char.IsWhiteSpace) + 1;


            Console.WriteLine("Caracteres: {0} Palavras: {1} \n" +
                "", contadorDeCaracteres, contadorDePalavras);

            var contadorDeLetras = escrito.Where(char.IsLetterOrDigit)
                           .GroupBy(char.ToUpper)
                           .Select(counter => new { Letter = counter.Key, Counter = counter.Count() });

            foreach (var contador in contadorDeLetras)
            {
                Console.WriteLine(String.Format("{0}: {1}", contador.Letter, contador.Counter));
            }

        }

    }
}
