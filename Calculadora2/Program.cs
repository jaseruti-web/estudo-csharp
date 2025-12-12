using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual é a operação");
            Console.WriteLine("1 Adicao");
            Console.WriteLine("2 subtracao");
            Console.WriteLine("3 multiplicacao");
            Console.WriteLine("4 divisao\n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero da operacao");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero da operacao");
            int num2 = int.Parse(Console.ReadLine());

            int resultado=0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1,num2);
                        break;
                    }
                case 2:
                    {
                        resultado = subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Numero invalido, digite outro numero");
                    break;
            }

            Console.WriteLine("O resultado da operação com os numeros é:{0} e {1} e {2}",num1,num2, resultado);
            Console.ReadLine();
        }














        public static int Adicao(int numero1, int numero2)
            {
            int result= numero1 + numero2;        
            return result;
            }
        public static int subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }
        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }
        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }

    }
}
 