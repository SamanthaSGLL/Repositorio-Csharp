using Aulas.Models; // fazemos isso porque está em Pessoas.cs

DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy  HH:mm"  ));







string apresentacao = "Olá, seja bem-vindo.";

int quantidade = 1;


double altura =1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel quantidade: " +quantidade);
Console.WriteLine("Valor da variavel altura: " +altura.ToString("0.00"));  // ToString para apresentar 2 casas decimais após o ponto
Console.WriteLine("Valor da variavel preco: " +preco);
Console.WriteLine("Valor da variavel condição : " +condicao);




Pessoa pessoa1 = new Pessoa();

pessoa1.Nome= "Samantha";
pessoa1.Idade=26;
pessoa1.Apresentar();


