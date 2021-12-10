/* Tempo de um Evento

Pedrinho está organizando um evento em sua Universidade. O evento deverá ser
no mês de Abril, iniciando e terminando dentro do mês. O problema é que
Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe
quando inicia e quando termina o evento.

Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá
ajudar Pedrinho a calcular a duração deste evento.

- Entrada

Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um
espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será
informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na
terceira e quarta linha de entrada haverá outra informação no mesmo formato
das duas primeiras linhas, indicando o término do evento.

- Saída

Na saída, deve ser apresentada a duração do evento, no seguinte formato:

W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)

Obs: Considere que o evento do caso de teste para o problema tem duração mínima
de 1 minuto.*/

using System;

namespace desafio4
{
    class Program
    {
        static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(":");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);    

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(":");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);

            var time = new TimeSpan(horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio);
            var time2 = new TimeSpan(horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino);
            var total = new TimeSpan();
            var time24 = new TimeSpan(24,00,00);
            int dias = diaTermino-diaInicio;

            if (diaInicio == diaTermino)
            {
                total = time2 - time;
            }
            else
            {
                if(dias == 1)
                {
                    total = (time24 - time) + time2;
                    if(total< time24)
                    {
                        dias = 0;
                    }
                }
                else
                {
                    total = (time24 - time) + time2 + time24;
                }
            }            
            Console.WriteLine("{0} dia(s)", dias);
            Console.WriteLine("{0} hora(s)", total.Hours);
            Console.WriteLine("{0} minuto(s)", total.Minutes);
            Console.WriteLine("{0} segundo(s)", total.Seconds);
        }
    }
}
