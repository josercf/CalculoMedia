using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculoDeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Avaliacao av1 = new Avaliacao();
            Avaliacao av2 = new Avaliacao();
            Avaliacao av3 = new Avaliacao();

            av1.NotaTrabalho = 4.5F;
            av1.NotaProva = 6;

            av2.NotaTrabalho = 7.3F;
            av2.NotaProva = 3;

            av3.NotaProva = 6.6F;

            List<Avaliacao> notas = new List<Avaliacao>();
            notas.Add(av1);
            notas.Add(av2);
            notas.Add(av3);

            float media = notas.OrderByDescending(x => x.Nota)
                               .Take(2)
                               .Sum(c => c.Nota) / 2;


            var soma = 0F;
            for (int i = 0; i < notas.Count; i++)
            {
                soma += notas[i].Nota;
            }










            //3 - Avaliações
            //AV1 - 40% de trabalhos e 60% nota da Prova;
            //AV2 - 40% de trabalhos e 60% nota da Prova;
            //AV3 - 100% nota da Prova;

            //AV1   AV2   AV3   Média     Resultado
            // 7      4     3     5,5       Reprovado




            //Descarta a menor nota e tira-se a média das duas restantes;
            //Par o aluno ser aprovado, a média precisa ser igual ou maior a 6;

            //5 disciplinas;
            //7 alunos;
        }
    }


    class Avaliacao
    {
        public float NotaTrabalho { get; set; }
        public float NotaProva { get; set; }

        public float Nota => (NotaTrabalho * 0.4F) + (NotaProva * 0.6F);

        //int: 5
        //float:   5.51234                        4 bytes
        //double:  5.12345678901234               8 bytes  
        //decimal: 0.12345678901234567890123456  16 bytes

        //         0,0052054794520548

        //1000 *



        //0,000012
    }
}
