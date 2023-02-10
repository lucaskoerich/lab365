string nome, sobrenome, corFavorita;
int idade;

Console.WriteLine("Olá, tudo bem? Qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenome = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é a sua cor favorita?");
corFavorita = Console.ReadLine();

Console.WriteLine("Nome: " + nome);
Console.WriteLine("Sobrenome: " + sobrenome);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Cor favorita: " + corFavorita);