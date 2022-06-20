using Lab.Entity.Implementation;
using Lab.Entity.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [Route("Inserir")]
        [HttpGet]
        public List<Cliente> Index()
        {

            return _clienteService.Listar();

        }
    }
}

