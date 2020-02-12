using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA("Rogue");

            jogo.IniciarJogo();
        }
    }

    class JogoFODA
    {
        private readonly string _nome;

        public JogoFODA(string nome)
        {
            _nome = nome;
        }
        public void IniciarJogo()
        {
            Console.Write($"{_nome} Passe realizado");
        }
    }
}
