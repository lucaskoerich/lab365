using Exercicio01;

FichaInscricao inscrito = new FichaInscricao()
{
    Id = 15,
    Nome = "Lucas",
    DataNascimento = DateTime.Parse("27/05/2001"),
    MenorIdade = true
};

inscrito.MostrarClasse();