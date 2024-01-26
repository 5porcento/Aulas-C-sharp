using Aula.Models;

Pessoa p1 = new Pessoa(nome:"Kauan",sobrenome: "Pacheco");
Pessoa p2 = new Pessoa(nome:"Luna",sobrenome: "Queiroz");

Curso cursoDeLancamento = new Curso();
cursoDeLancamento.Nome = "Lançamento";
cursoDeLancamento.Alunos = new List<Pessoa>();

cursoDeLancamento.AdicionarAluno(p1);
cursoDeLancamento.AdicionarAluno(p2);
cursoDeLancamento.ListarAlunos();