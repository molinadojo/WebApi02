using Microsoft.AspNetCore.Mvc;
using WebApiSQL.Models;

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
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = 1,
                    nombre = "lautarito molina",
                    edad = "30",
                    correo = "googleso@gmailcom",

                },
                new Cliente
                {
                    id = 2,
                    nombre = "lucho molina",
                    edad = "14",
                    correo = "algo@gmailcom",

                }
            };
            return clientes;
        }
    }
}
