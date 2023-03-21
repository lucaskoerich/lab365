namespace Aula03;

public class Aluno
{
    public static List<Aluno> Alunos { get; } = new List<Aluno>();

    public string Nome { get; set; }
    public string CPF { get; set; }
    public int Turma { get; set; }
}