int lado1, lado2, lado3;

Console.WriteLine("Insira três lados de um triângulo:");

Console.WriteLine("Lado 1:");
lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Lado 2:");
lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Lado 3:");
lado3 = int.Parse(Console.ReadLine());

if ((lado1 + lado2) > lado3 && (lado2 + lado3) > lado1)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("Triângulo Isósceles ");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}
else
{
    Console.WriteLine("Não é um triângulo");
}