Console.WriteLine("Sequência de Fibonacci: ");

int numero1 = 0;
int numero2 = 1;
int soma;


for (int i = 0; i < 20; i++)
{
    soma = numero1 + numero2;
    Console.WriteLine(soma);

    numero1 = numero2;
    numero2 = soma;
}