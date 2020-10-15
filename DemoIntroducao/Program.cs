using System;
using System.Collections.Generic;

namespace DemoIntroducao
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Aluno> alunos = new List<Aluno>();


            for (int i = 0; i < 4; i++)
            {
                Aluno aluno = new Aluno();


                Console.WriteLine("Informe o nome do aluno:");
                aluno.Nome = Console.ReadLine();

                if(aluno.NomeEhValido() == false)
                {
                    Console.WriteLine("O nome digitado é inválido");
                }


                Console.WriteLine("Informe o endereço do aluno:");
                aluno.Endereco = Console.ReadLine();

                Console.WriteLine("Informe a data de nascimento do aluno:");
                aluno.DataNascimento = Console.ReadLine();


                alunos.Add(aluno);


                Console.WriteLine("Deseja cadastrar um novo aluno? S - Sim/N - Não");
                string resposta = Console.ReadLine();

                if (resposta == "N")
                    break;


            }

            Console.WriteLine("******************");


            Console.WriteLine("Nome        | Endereço         | Dt. Nasc.       ");
            foreach (var item in alunos)
            {
                Console.WriteLine($"{item.Nome} | {item.Endereco} | {item.DataNascimento}");
            }


            //Console.WriteLine($"Nome: { aluno.Nome}");
            //Console.WriteLine($"Endereço: { aluno.Endereco}");
            //Console.WriteLine($"Data Nasc.: { aluno.DataNascimento}");
        }
    }

    class Aluno
    {
        public string Nome;
        public string DataNascimento;
        public string Endereco;
        public string RA;


        public bool NomeEhValido()
        {
            return Nome.Length > 5;
        }
    }
}
