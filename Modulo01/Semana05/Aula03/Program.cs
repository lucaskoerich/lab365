using Aula03;

Aluno alunos = new Aluno()
{
    CPF = "125215",
    Nome = "Lucas",
    Turma = 15
};

Aluno alunos1 = new Aluno()
{
    CPF = "1252f15",
    Nome = "Maria",
    Turma = 15
};

Aluno alunos2 = new Aluno()
{
    CPF = "1252asdad15",
    Nome = "Joao",
    Turma = 15
};

List<Aluno> listaAlunos = new List<Aluno>();

listaAlunos.Add(alunos);
listaAlunos.Add(alunos1);
listaAlunos.Add(alunos2);

var existe = listaAlunos.Exists (x => x.Nome == "Joao");
var existe2 = listaAlunos.Exists (x => x.Nome == "Joao Cleber");
Console.WriteLine(existe);
Console.WriteLine(existe2);
var listaAluno2 = listaAlunos.Where(x => x.Nome == "Lucas").ToList();

var existe3 = listaAluno2.Exists(x => x.Nome == "Lucas");
Console.WriteLine(existe3);



