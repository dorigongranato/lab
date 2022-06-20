using Dapper.Contrib.Extensions;
using Lab.Entity.Interface;

namespace Lab.Entity.Implementation
{
    [Table("TransportePessoal")]
    public class TransportePessoal : TransporteBase, ITransporte
    {
        [Key]
        public int idTransportePessoal { get; set; }

        public string Tipo { get; set; }

        private ITransportePessoalService _transportePessoalService;


        public TransportePessoal(ITransportePessoalService transportePessoalService)
        {
            _transportePessoalService = transportePessoalService;
        }

        public string OperacaoDeTransporte()
        {


            //ITransportePessoalService x = new


            return "{Result of TrasportePessoal} " + Passeio();
        }

        public string Passeio()
        {

            Inserir();

            return "Levando a família ao shopping";
        }

        public void Inserir()
        {
            _transportePessoalService.Inserir(this);
        }
    }
}