// Ex.1

using Exercicios0611;

Pessoa pessoa1 = new Pessoa();

pessoa1.nome = "João";
pessoa1.idade = 25;
pessoa1.cidade = "São Paulo";

Pessoa pessoa2 = new Pessoa();

pessoa2.nome = "John";
pessoa2.idade = 25;
pessoa2.cidade = "New York";

pessoa1.apresentar();
pessoa2.apresentar();

// Ex.2


Calculadora calculadora = new Calculadora();

calculadora.Somar(10, 5);
calculadora.Subtrair(10, 5);
calculadora.Multiplicar(10, 5);


Calculadora.Dividir(10, 5);

// Ex.3
Veiculo carro = new Veiculo();

//// teste (menor que 200)
carro.Velocidade = 100;
Console.WriteLine($"Velocidade atual: {carro.Velocidade} km/h");

//// teste (200)
carro.Velocidade = 200;
Console.WriteLine($"Velocidade atual: {carro.Velocidade} km/h");

//// teste inválido (maior que 200)
carro.Velocidade = 250;
Console.WriteLine($"Velocidade atual: {carro.Velocidade} km/h");

// Ex.4 
Funcionario funcionario = new Funcionario();

funcionario.Nome = "João";
funcionario.Cargo = "Desenvolvedor";

funcionario.AumentarSalario(10);

funcionario.ConsultarSalario();
// Ex.5
//// livro1 Recebe livro sem parâmetros 
Livro livro1 = new Livro();

//// livro2 Recebe livro apenas com título
Livro livro2 = new Livro("Dom Casmurro");

//// livro3 Recebe livro com título e autor
Livro livro3 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry");

//// livro4 Recebe livro com título, autor e número de páginas
Livro livro4 = new Livro("1984", "George Orwell", 328);

livro1.ExibirDados();
livro2.ExibirDados();
livro3.ExibirDados();
livro4.ExibirDados();