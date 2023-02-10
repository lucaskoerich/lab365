double salarioBruto, desconto;

Console.WriteLine("Digite o valor do salário bruto:");
salarioBruto = Double.Parse(Console.ReadLine());

if (salarioBruto <= 900)
{
    Console.WriteLine("Isento. R$0.00");
}
else if (salarioBruto <= 1500)
{
    desconto = ((salarioBruto / 100) * 5);
    Console.WriteLine("R$" + desconto);
}
else if (salarioBruto <= 2500)
{
    desconto = ((salarioBruto / 100) * 10);
    Console.WriteLine("R$" + desconto);
}
else
{
    desconto = ((salarioBruto / 100) * 20);
    Console.WriteLine("R$" + desconto);
}