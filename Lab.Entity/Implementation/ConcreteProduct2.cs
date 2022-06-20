using System;
namespace Lab.Entity.Implementation
{
    public class ConcreteProduct2 : ITransporte
    {
        public string Inserir()
        {
            return "{Result of TrasportePessoal} " + Passeio();

        }

        public string Passeio()
        {
            return "Levando a família ao shopping";
        }
    }
}

