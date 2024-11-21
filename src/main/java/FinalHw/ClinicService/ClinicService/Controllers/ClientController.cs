using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "ClientCreate")]
        public ActionResult<int> Create([FromBody] CreateClientRequest createRequest)
        {
            int res = _clientRepository.Create(new Client
            {
                Document = createRequest.Document,
                SurName = createRequest.SurName,
                FirstName = createRequest.FirstName,
                Patronymic = createRequest.Patronymic,
                Birthday = createRequest.Birthday
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "ClientUpdate")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<int> Update([FromBody] UpdateClientRequest updateRequest)
        {
            int res = _clientRepository.Update(new Client
            {
                ClientId = updateRequest.ClientId,
                Document = updateRequest.Document,
                SurName = updateRequest.SurName,
                FirstName = updateRequest.FirstName,
                Patronymic = updateRequest.Patronymic,
                Birthday = updateRequest.Birthday
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "ClientDelete")]
        public ActionResult<int> Delete([FromQuery] int clientId)
        {
            int res = _clientRepository.Delete(clientId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "ClientGetAll")]
        public ActionResult<List<Client>> GetAll()
        {
            //if (random.Next(2) == 0)
            //{
            //    return Ok(_clientRepository.GetAll());
            //}
            //else
            //{
            //    List<Client> list = new List<Client>();
            //    list.Add(new Client());
            //    return Ok(list);
            //}
            return Ok(_clientRepository.GetAll());
        }

        static Random random = new Random();

        [HttpGet("get/{clientId}")]
        [SwaggerOperation(OperationId = "ClientGetById")]
        public ActionResult<Client> GetById([FromRoute] int clientId)
        {
            return Ok(_clientRepository.GetById(clientId));
        }
    }
}
