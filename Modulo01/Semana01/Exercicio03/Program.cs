double nota1, nota2, nota3, media;

Console.WriteLine("Insira a primeira nota:");
nota1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota:");
nota2 = Double.Parse(Console.ReadLine());

Console.WriteLine("Insira a terceira nota:");
nota3 = Double.Parse(Console.ReadLine());

media = ((nota1 + nota2 + nota3) / 3);

if (media >= 6)
{
    Console.WriteLine("Aluno aprovado! Média " + media);
}
else if (media >= 5)
{
    Console.WriteLine("Aluno em recuperação! Média " + media);
}
else
{
    Console.WriteLine("Aluno reprovado! Média " + media);
}