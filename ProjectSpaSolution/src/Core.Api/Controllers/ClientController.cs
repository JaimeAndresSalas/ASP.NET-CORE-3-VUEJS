
using Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Model.Dtos;

namespace Core.Api.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService) {
            _clientService = clientService;
        }

        [HttpPost]
        public async Task<ActionResult> Create(ClientCreateDto model)
        {
            await _clientService.Create(model);

            return Ok();
        }
    }
    
}