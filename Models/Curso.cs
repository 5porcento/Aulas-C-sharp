using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set;}

        public void AdicionarAluno(Pessoa aluno) 
        {
        Alunos.Add(aluno);
        }

        public int ObterQntdDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoveAluno(Pessoa aluno)
        { 
           return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do Curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N° {count +1 } - { Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}
