string nome;
int quantidadeNotas;
double notaFinal = 0;

Console.WriteLine("Qual é o nome do aluno?");
nome = Console.ReadLine();

Console.WriteLine("Quantas notas serão cadastradas?");
quantidadeNotas = int.Parse(Console.ReadLine());

double[] notas = new double[quantidadeNotas];

for (int i = 0; i < quantidadeNotas; i++)
{
    Console.WriteLine($"Digite a {i + 1}a nota:");
    notas[i] = Double.Parse(Console.ReadLine());
    notaFinal += notas[i] / quantidadeNotas;
}

Console.WriteLine($"Aluno: {nome}");

for (int i = 0; i < quantidadeNotas; i++)
{
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
}

if (notaFinal >= 6)
{
    Console.WriteLine("Aluno aprovado! Média " + notaFinal);
}
else if (notaFinal >= 5)
{
    Console.WriteLine("Aluno em recuperação! Média " + notaFinal);
}
else
{
    Console.WriteLine("Aluno reprovado! Média " + notaFinal);
}