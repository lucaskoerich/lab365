using ExercicioHeranca;

Carro carro = new Carro();

carro.Velocidade = 0;

Console.WriteLine(carro.Velocidade);

carro.Acelerar(5);
Console.WriteLine(carro.Velocidade);

carro.Acelerar(5);
Console.WriteLine(carro.Velocidade);

carro.Acelerar(5);
Console.WriteLine(carro.Velocidade);

carro.Parar();
Console.WriteLine(carro.Velocidade);

