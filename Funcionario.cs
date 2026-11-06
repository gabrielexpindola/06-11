
namespace Exercicios0611
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; private set; }

        public void    AumentarSalario(double percentual)
        {
            if (percentual > 0)
            {
                Salario += Salario * (percentual / 100);
            }
            else
            {
                Console.WriteLine("Percentual inválido!");
            }
        }
        public void ConsultarSalario()
        {
            Console.WriteLine($"Salário atual: {Salario:C}");
        }
    }
}