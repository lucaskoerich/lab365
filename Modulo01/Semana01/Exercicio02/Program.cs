double baseTriangulo, alturaTriangulo, area;

Console.WriteLine("Insira o valor da base do triângulo");
baseTriangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor da altura do triângulo");
alturaTriangulo = double.Parse(Console.ReadLine());

area = ((baseTriangulo * alturaTriangulo) / 2);

Console.WriteLine("A área do triângulo é: " + area);