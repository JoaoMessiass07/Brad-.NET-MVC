using System;
using Recap;
using Recap.Aluno;

namespace Recap
{
    class Program
    {
        static DadoAluno[] alunos;
        //static DadoAluno aluno2;

        static void Main(string[] args)
        {

            Console.WriteLine("Quantos alunos sua sala possui?");
            int numeroAlunos = Int32.Parse(Console.ReadLine());
            alunos = new DadoAluno[numeroAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {   
                Print("Dados do aluno " + (i + 1));
                Console.WriteLine("Qual o nome do seu aluno?");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual a idade do seu aluno?");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o curso do seu aluno?");
                string curso = Console.ReadLine();

                Console.WriteLine("Qual a nota do seu curso?");
                float nota = float.Parse(Console.ReadLine());
                Console.WriteLine();

                alunos[i] = new DadoAluno(nome, idade, curso, nota);
            }

            foreach (DadoAluno aluno in alunos)
            {
                Print(aluno.RetornaDadosAluno());
            }
           
        }
        public static void Print(string text)
        {   
            Console.WriteLine(text);
        }
    }
}
