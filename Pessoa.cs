
namespace Exercicios0611
{
    public class Pessoa
    {
    public string nome { get; set; }
    public int idade { get; set; }
    public string cidade { get; set; }

    public void apresentar()
    {
        Console.WriteLine(
            $"Olá! Meu nome é {nome}, tenho {idade} anos e moro em {cidade}."
        );
    }
    }
}