
namespace Exercicios0611
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} e {b} é: {resultado}");
        }
        public void Subtrair(int a, int b)
        {
            int resultado = a - b;
            Console.WriteLine($"A subtração de {a} e {b} é: {resultado}");
        }
        public void Multiplicar(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"A multiplicação de {a} e {b} é: {resultado}");
        }
        public static void Dividir(int a, int b)
        {
            if (b != 0)
            {
                double resultado = (double)a / b;
                Console.WriteLine($"A divisão de {a} por {b} é: {resultado}");
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
        }
        
    }
}