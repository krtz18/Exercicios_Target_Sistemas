using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Exercicios_Target_Sistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Descomente o void para rodar o exercicio que deseja.

            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
        }

        // ------ EXERCICIO 1 ------
        static void Exercicio1()
        {
            int indice = 13;
            int resultado = 0;

            for (int x = 0; x < indice; x++)
            {
                resultado += x;
            }
            Console.WriteLine(resultado); // RESULTADO = 78
            Console.ReadLine();
        }

        // ------ EXERCICIO 2 ------
        static void Exercicio2()
        {

            int numero1 = 0, numero2 = 1, aux;
            bool opcao = false;
            Console.WriteLine("Digite um numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i​​​​​​​ < 8; i++)
            {
                aux = numero1;
                numero1 = numero2;
                numero2 = numero1 + aux;
                Console.WriteLine("{0}", numero2);

                if (numero2 == numero3)
                {
                    opcao = true;
                }

            }

            if (opcao == true)
            {
                Console.WriteLine("O numero está na sequencia de Fibonacci");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("O numero não está na sequencia de Fibonacci");
                Console.ReadLine();
            }
        }

        // ------ EXERCICIO 3 ------
        static void Exercicio3()
        {
            string fileName = @"C:\Users\gusta\Downloads\dados.json";
            StreamReader r = new StreamReader(fileName);
            string jsonString = r.ReadToEnd();
            List<Faturamento> faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);

            decimal menorFaturamento = 999999999999999;
            decimal maiorFaturamento = 0;
            decimal total = 0;
            decimal media = 0;
            int dias = 0;

            foreach (var item in faturamento)
            {
                total += item.valor;
                media = total / faturamento.Count;
            }

            foreach (var item in faturamento)
            {
                if (item.valor < menorFaturamento)
                {
                    menorFaturamento = item.valor;
                }

                if (item.valor > maiorFaturamento)
                {
                    maiorFaturamento = item.valor;
                }
                if (item.valor > media)
                {
                    dias++;
                }
            }
            Console.WriteLine("O menor faturamento é: " + menorFaturamento);
            Console.WriteLine("O maior faturamento é: " + maiorFaturamento);
            Console.WriteLine("O número de dias em que o faturmanto foi maior que a media foram " + dias + " e a média é " + media.ToString("F"));
            Console.ReadLine();

        }
        public class Faturamento
        {
            public int dia { get; set; }
            public decimal valor { get; set; }
        }

        // ------ EXERCICIO 4 ------
        static void Exercicio4()
        {
            double sp = 67.83643;
            double rj = 36.67866;
            double mg = 29.22988;
            double es = 27.16548;
            double outros = 19.84953;


            double total = (sp + rj + mg + es + outros);
            Console.WriteLine("A valor total é " + total);

            Console.WriteLine("Porcentagem de SP é " + (((sp * 100) / total)).ToString("F"));
            Console.WriteLine("Porcentagem de RJ é " + (((rj * 100) / total)).ToString("F"));
            Console.WriteLine("Porcentagem de MG é " + (((mg * 100) / total)).ToString("F"));
            Console.WriteLine("Porcentagem de ES é " + (((es * 100) / total)).ToString("F"));
            Console.WriteLine("Porcentagem dos outros estados é " + (((outros * 100) / total)).ToString("F"));

            Console.ReadLine();
        }

        static void Exercicio5()
        {

            Console.WriteLine("Digite uma palavra: ");
            string str = Console.ReadLine();

            char[] ch = new char[str.Length];
            string strcontrario = "";

            for (int i = 0; i < str.Length; i++)
            {
                strcontrario += str[(str.Length - 1) - i];
            }

            Console.WriteLine("A palavra ao contrario fica: " + strcontrario);
            Console.ReadLine();
        }

    }
}
