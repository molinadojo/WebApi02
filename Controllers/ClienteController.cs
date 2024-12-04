using Microsoft.AspNetCore.Mvc;

namespace WebApiSQL.Controllers //de donde sale
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            // todo el codigo que deseemos
            return new
            {
                nombre = "lautaro",
                apellido = "Molina"
            };
        }
    }
}
