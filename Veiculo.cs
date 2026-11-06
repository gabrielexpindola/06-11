using System;

namespace Exercicios0611
{
    public class Veiculo
    {
        private int velocidade;

        public int Velocidade
        {
            get
            {
                return velocidade;
            }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    velocidade = value;
                }
                else
                {
                    Console.WriteLine("Velocidade inválida!");
                }
            }
        }
    }
}