using BR_Cash.estidades;
using BR_Cash.Interfaces.interfaceService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class poupancaController : ControllerBase 
    {
        private readonly IpoupancaService _service;

        public poupancaController(IConfiguration config, IpoupancaService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
           _service = service;

       }
       [HttpPost("adicionar-usuario")]
        public void AdicionarCaminhao(Conta_Poupanca caminhao)
        {
            _service.Adicionar(caminhao);

}
        [HttpGet("listar-usuario")]
        public List<Conta_Poupanca> ListarContaPorId(int id)
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
