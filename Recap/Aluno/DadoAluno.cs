using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Aluno
{
    class DadoAluno
    {
        public string nome;
        public int idade;
        public string curso;
        public float nota;

        public DadoAluno() { }

        public DadoAluno(string nome, int idade, string curso, float nota)
        {
            this.nome = nome;
            this.idade = idade;
            this.curso = curso;
            this.nota = nota;
        }

        public string RetornaDadosAluno()
        {
            return "nome: " + nome +
                ", idade: " + idade +
                ", curso: " + curso +
                ", nota: " + nota;
        }
    }
}
