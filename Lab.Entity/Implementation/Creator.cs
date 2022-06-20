namespace Lab.Entity.Implementation
{
    abstract class Creator
    {
        public abstract ITransporte FactoryMethod();

        public string IniciarTransporte()
        {
            var transporte = FactoryMethod();
            return transporte.Inserir();
        }
    }
}