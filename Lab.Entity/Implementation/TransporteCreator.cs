using Dapper.Contrib.Extensions;

namespace Lab.Entity.Implementation
{
    class TransporteCreator : Creator
    {
        public string Produto { get; set; }

        public override ITransporte FactoryMethod()
        {
            //Criação dos objetos de acordo com o produto
            /*if (string.IsNullOrEmpty(Produto) && !string.IsNullOrEmpty(Produto))
            {
                return new TransportePessoal();
            }*/
            return new TransportePessoal();
        }
    }
}