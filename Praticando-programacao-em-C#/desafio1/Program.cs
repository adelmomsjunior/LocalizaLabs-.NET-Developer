/*  Coordenadas de um Ponto

Leia 2 valores com uma casa decimal (x e y), que devem representar as 
coordenadas de um ponto em um plano. A seguir, determine qual o quadrante 
ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na 
origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

Entrada
A entrada contem as coordenadas de um ponto.

Saída
A saída deve apresentar o quadrante em que o ponto se encontra.*/

using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b;            
            string[] num = Console.ReadLine().Split();
            a = Convert.ToDecimal(num[0]);
            b = Convert.ToDecimal(num[1]);

            if (a != 0 && b != 0)
            {
                if (a > 0)
                {
                    if(b>0)
                    {
                        Console.WriteLine("Q1");
                    }
                    else
                    {
                        Console.WriteLine("Q4");
                    }
                }
                else
                {
                    if(b>0)
                    {
                        Console.WriteLine("Q2");
                    }
                    else
                    {
                        Console.WriteLine("Q3");
                    }
                }
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("Origem");
            }
            else 
            {
                if (a==0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else
                {
                    Console.WriteLine("Eixo X");
                }
            }
        }
    }
}
