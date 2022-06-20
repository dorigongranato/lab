namespace Lab.Entity.Implementation
{
    public class Transporte
    {
        ////Controle
        //public string Produto { get; set; }

        //// BASE
        //public int AnoFabricacao { get; set; }
        //public DateTime DataCadastro { get; set; }

        ////Pessoal 
        //public string Tipo { get; set; }

        //// Carga
        //public int PesoCarga { get; set; }

        //Inicia a criação dos objetos de acordo com o produto
        public void Iniciar(ITransportePessoalService transportePessoalServiceß)
        {
            //Criação dos objetos foram colocados dentro de TransporteCreator
            CriarTransporte(new TransporteCreator());

        }

        void CriarTransporte(Creator creator)
        {
            // ...
            Console.WriteLine("Client: Inciando a rota de transporte.\n" + creator.RotaTransporte());
            // ...
        }
    }

    public interface ITransporte
    {
        string OperacaoDeTransporte();
    }

}
