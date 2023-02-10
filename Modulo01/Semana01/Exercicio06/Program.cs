int numero;

Console.WriteLine("Digite o número que deseja criar a tabuada:");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = " + (numero * i));
}