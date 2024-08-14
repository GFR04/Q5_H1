using Microsoft.AspNetCore.Mvc;

namespace Questão5_H1.Controllers
{
        [ApiController]
    [Route("Api/pessoa")]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        [Route("CalcularIMC")]

        public IActionResult CalcularIMC(Pessoa _pessoa)
        {
            if (_pessoa.Altura <= 0 || _pessoa.Peso <= 0)
            {
                return BadRequest("Peso e altura devem ser maiores que zero");
            }
            return Ok($"O valor do seu IMC é {_pessoa.Nome} é {_pessoa.CalcularIMC().ToString("F2")}");
        }
        [HttpPost]
        [Route("ConsultarTabelaIMC")]
        public IActionResult ConsultarTabelaIMC (Pessoa _pessoa)
        {
            if (_pessoa.Altura <= 0 || _pessoa.Peso <= 0) 
            {
                return BadRequest("Peso e altura devem ser maior de zero.");
            }
            double IMC = _pessoa.CalcularIMC();
            if (IMC < 18.5)
            {
                return Ok("Muito abaixo do peso.");
            }

            else if (IMC >= 18.6 && IMC <= 24.9)
            {
                return Ok("Abaixo do peso");
            }

            else if (IMC >= 25 && IMC <= 29.9)
            {
                return Ok("Acima do peso");
            }

            else if (IMC >= 30 && IMC <= 34.9)
            {
                return Ok("Obsedidade grau I");
            }

            else if (IMC >= 35 && IMC <= 39.9)
            {
                return Ok("Obsedidade grau II");
            }
            return Ok("Obesidade grau III");
        }
    }
}
