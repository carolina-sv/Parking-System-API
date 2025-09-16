using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParkingSystemApi.Models;
using ParkingSystemApi.Services;

namespace ParkingSystemApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstacionamentoController : ControllerBase
    {
        private readonly EstacionamentoService _service;

        public EstacionamentoController(EstacionamentoService service)
        {
            _service = service;
        }

        //--- GET api/estacionamento
        [HttpGet]
        public ActionResult<List<Veiculo>> GetVeiculos()
        {
            return _service.ListarVeiculos();
        }

        //--- POST api/estacionamento/ABC1234
        [HttpPost("{placa}")]
        public IActionResult AdicionarVeiculo(string placa)
        {
            _service.AdicionarVeiculo(placa);
            return Ok(new { message = $"Veículo {placa} adicionado com sucesso!" });
        }

        //--- DELETE api/estacionamento/ABC1234
        [HttpDelete("{placa}")]
        public IActionResult RemoverVeiculo(string placa)
        {
            var valor = _service.RemoverVeiculo(placa);
            if (valor == null)
                return NotFound(new { message = "Veículo não encontrado!" });

            return Ok(new { message = $"Veículo {placa} removido", valorPagar = valor });
        }
    }
}
