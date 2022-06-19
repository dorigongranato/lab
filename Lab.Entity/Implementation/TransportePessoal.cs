using Dapper.Contrib.Extensions;

namespace Lab.Entity.Implementation
{
    [Table("TransportePessoal")]
    class TransportePessoal : Creator
    {
        [Key]
        public int idTransportePessoal { get; set; }

        public string Tipo { get; set; }

        public override ITransporte FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteProduct1 : ITransporte
    {
        public string OperacaoDeTransporte()
        {
            return "{Result of TrasportePessoal} " + Passeio();

        }

        public string Passeio()
        {
            return "Levando a família ao shopping";
        }
    }
}