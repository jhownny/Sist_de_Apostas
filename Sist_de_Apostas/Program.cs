using System;


namespace Sist_de_Apostas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[0];
            Random random = new Random();


            Console.WriteLine("Digite a quantidade de cartões que deseja:");

            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quatidade de numeros que deseja:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros.Length; i++)
            {
                int aposta = random.Next(numero, quantidade);
                if (i == 0) ;

                numeros[i] = aposta;

                else
                {

                    if (Array.BinarySearch(numeros, aposta) < 0) ;
                    numeros[i] = aposta;


                }

                if (i != numeros.Length - 1)
                    Console.WriteLine(numeros[i] + "-");
                else
                    Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();
            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++) ;
            {
                if (i != numeros.Length - 1)
                    Console.Write(numeros[i] + "-");
                else
                    Console.WriteLine(numeros[i]);



            }
               


            
        
               
                
                //int c = random.Next(numero, quantidade);
                //int[,] m = new int[numero, quantidade];


            
        }    
            


            
        

    }
}
