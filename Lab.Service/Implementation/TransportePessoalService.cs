using Lab.Entity.Implementation;
using Lab.Repository.Interface;
using Lab.Service.Interface;

namespace Lab.Service.Implementation
{
    public class TransportePessoalService : ITransportePessoalService
    {
        private readonly ITransportePessoalRepository _transportePessoalRepository;

        public TransportePessoalService(ITransportePessoalRepository transportePessoalRepository)
        {
            _transportePessoalRepository = transportePessoalRepository;
        }

        public void Inserir(TransportePessoal transportePessoal)
        {
            _transportePessoalRepository.Inserir(transportePessoal);
        }
    }
}