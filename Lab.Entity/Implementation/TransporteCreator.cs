using Dapper.Contrib.Extensions;

namespace Lab.Entity.Implementation
{
    class TransporteCreator : Creator
    {
        public override ITransporte FactoryMethod()
        {
            //Criação dos objetos de acordo com o produto
            return new TransportePessoal();
        }
    }
}