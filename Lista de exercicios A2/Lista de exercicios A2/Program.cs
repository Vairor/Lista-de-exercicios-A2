using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaA2
{
    class Program
    {


        public class Conta
        {
            private int saldo;
            private int conta;
            private int totalCobrancas;
            private int totalCredito;
            private int limiteCredito;

            public Conta(int saldo, int conta, int cobrancas, int credito, int limite)
            {
                this.saldo = saldo;
                this.conta = conta;
                this.totalCobrancas = cobrancas;
                this.totalCredito = credito;
                this.limiteCredito = limite;
            }
            public int CalcularNovoSaldo()
            {
                return this.saldo + this.totalCobrancas - this.totalCredito;
            }

            public void AtualizarSaldo()
            {
                this.saldo = CalcularNovoSaldo();
            }

            public bool Limite()
            {
                return this.saldo > this.limiteCredito;
            }
        }

        static void Main(string[] args)
        {

            //Exercicio 01
            string strquatrodigitos = "";
            int intquatrodigitos = 0;
            int unidade = 0;
            int dezena = 0;
            int centena = 0;
            int unidadeDeMilhar = 0;
            int restoDivisao = 0;
            int quociente = 0;
            const int DECIMAL = 10;

            Console.WriteLine("Por favor digite um inteiro de 4 digitos.");
            strquatrodigitos = Console.ReadLine();

            if (strquatrodigitos.Contains(" "))
            {
            espaço:
                Console.Clear();
                Console.WriteLine("Sem usar espaço, meu anjo.");
                Console.WriteLine("Por favor digite um inteiro de 4 digitos.");
                strquatrodigitos = Console.ReadLine();
                if (strquatrodigitos.Contains(" "))
                    goto espaço;
            }
            else if (strquatrodigitos.Contains("abcdefghijklmnopqrstuvxwyz"))
            {
            vogcons:
                Console.Clear();
                Console.WriteLine("Sem usar letras, cara.");
                Console.WriteLine("Por favor digite um inteiro de 4 digitos.");
                strquatrodigitos = Console.ReadLine();
                if (strquatrodigitos.Contains(" "))
                    goto vogcons;
            }
            else
            {
                intquatrodigitos = Convert.ToInt32(strquatrodigitos);

                restoDivisao = intquatrodigitos % DECIMAL;
                quociente = intquatrodigitos / DECIMAL;
                unidade = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                dezena = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                centena = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                unidadeDeMilhar = restoDivisao;
            }

            Console.Write("Numero Criptografado: {2} {3} {0} {1}.", unidadeDeMilhar + 7, centena + 7, dezena + 7, unidade + 7);
            Console.WriteLine("");
            menu.VoltarMenu();

        }


            //Questão 02
            Console.WriteLine("Digite o saldo atual ");
            int saldo = int.Parse(Console.ReadLine());

            Conta conta = new Conta(saldo, 20, 30, 200, 1000);

            Console.WriteLine("O seu novo saldo é de ");
            Console.WriteLine(conta.CalcularNovoSaldo());

            conta.AtualizarSaldo();
            Console.ReadKey();
            if (conta.Limite())
            {
                Console.WriteLine("Limite de crédito excedido!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Há crédito disponível.");
                Console.ReadKey();
            }

            //Exercicio 03.
            int numero = 0;

            Console.WriteLine("\nDigite um Numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
            Console.ReadKey();

            //Exercicio 04.
            int num1, num2, num3;

            Console.WriteLine("Digite um número inteiro");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro mais uma vez");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine("Triângulo equilátero");
            }
            else if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                Console.WriteLine("Triângulo escaleno");
            }
            else
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            Console.ReadKey();

            //Exercicio 05.
            char caracter;
            bool vogal = false;

            string[] vogais = new string[] { "a", "e", "i", "o", "u" };

            Console.Write("Informe uma letra: ");
            char.TryParse(Console.ReadLine(), out caracter);

            for (int i = 0; i < vogais.Length; i++)
            {
                if (vogais[i] == caracter.ToString())
                {
                    vogal = true;
                }
            }
            
            if (vogal)
            {
                Console.WriteLine("Esta letra é uma vogal.");
            }
            else
            {
                Console.WriteLine("Esta letra é uma consoante.");
            }

            //Exercicio 06.
            int n = 0, cont = 0;

            Console.WriteLine("Digite um numero que informaremos se ele é primo ou nao");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine("O numero " + n + " é primo.");
            }
            else
            {
                Console.WriteLine("O numero " + n + " não é primo!");
            }

            Console.ReadKey();
        }
    }
}
