using BR_Cash.estidades;
using BR_Cash.Interfaces.interfaceService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class correnteController : ControllerBase
    {
        private readonly IcorrenteService _service;

        public correnteController(IConfiguration config, IcorrenteService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;

        }
        [HttpPost("adicionar-usuario")]
        public void AdicionarCaminhao(Conta_Corrente caminhao)
        {
            _service.Adicionar(caminhao);
        }

        [HttpGet("listar-usuario")]
        public List<Conta_Corrente> ListarContaPorId(int id)
        {
            return _service.Listar(id);
        }

        [HttpDelete("deletar-usuario")]
        public void DeletarCaminhao(int id)
        {
            _service.Remover(id);
        }
    }
}
