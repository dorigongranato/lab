using Lab.Entity.Interface;

namespace Lab.Entity.Implementation
{
    public class Transporte
    {
        //Inicia a criação dos objetos de acordo com o produto
        public void Iniciar()
        {
            //Criação dos objetos foram colocados dentro de TransporteCreator
            CriarTransporte(new TransporteCreator());
        }

        void CriarTransporte(Creator creator)
        {
            creator.IniciarTransporte();
            //Console.WriteLine("Client: Inciando a rota de transporte.\n" + creator.RotaTransporte());
        }
    }

    public interface ITransporte
    {
        string Inserir();
    }

}
