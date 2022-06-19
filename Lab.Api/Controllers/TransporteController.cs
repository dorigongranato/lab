using AutoMapper;
using Lab.Entity.Implementation;
using Lab.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransporteController : ControllerBase
    {
        private readonly ITransportePessoalService _transportePessoalService;

        public TransporteController(ITransportePessoalService transportePessoalService)
        {
            _transportePessoalService = transportePessoalService;
        }

        [Route("Inserir")]
        [HttpPost]
        public void Inserir()
        {
            try
            {
                new Transporte().Iniciar();
                //_transportePessoalService.Inserir(transportePessoal);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}