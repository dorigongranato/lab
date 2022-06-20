namespace Lab.Entity.Implementation
{
    abstract class Creator
    {
        public abstract ITransporte FactoryMethod();

        public string RotaTransporte()
        {
            // Call the factory method to create a Product object.
            var transporte = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with " + transporte.OperacaoDeTransporte();

            return result;
        }
    }
}