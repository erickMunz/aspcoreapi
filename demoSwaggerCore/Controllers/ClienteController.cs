using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using demoSwaggerCore.Modelos;
using Swashbuckle.AspNetCore;

namespace demoSwaggerCore
{
    [Produces("application/json")]
    [Route("/Cliente")]

    public class ClienteController : Controller
    {
        private readonly BEPENSAContext BEcontext;

        public ClienteController(BEPENSAContext context)
        {
            BEcontext = context;
        }

    
        // GET: /Cliente
        /// <summary>
        /// Obtiene registros sobre los clientes
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/cliente
        ///     {
        ///     "nombre": "Daniel",
        ///      "apellidoPaterno": "Lopez",
        ///      "apellidoMaterno": "Rodriguez",
        ///      "direccionCalleContato": "Caramelo",
        ///      "direccionNumeroContacto": "12B",
        ///      "tipoPersona": 2,
        ///      "preferente": 3,
        ///      "correo": "daniloro@gmail.com",
        ///      "pais": 0,
        ///      "estado": 0,
        ///      "municipio": 0,
        ///      "colonia": 0
        ///     }
        ///
        /// </remarks>
        /// <param name="Cliente"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Regresa un elemento recien creado</response>
        /// <response code="400">Si existe un error en el contenido de la peticion</response> 
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return BEcontext.Cliente;
        }

        // GET: api/Cliente/5
        /// <summary>
        /// Obtiene registros sobre los clientes basados en un id
        /// </summary>
        [HttpGet("{id}", Name = "Get")]
       
        public Cliente Get(int id)
        {
            return BEcontext.Cliente.Find();
        }

        // POST: api/Cliente
        /// <summary>
        /// registra un cliente a la base de datos
        /// </summary>
        [HttpPost]
        public void Post([FromBody]Cliente cliente)
        {
        }
        /// <summary>
        /// Actualiza un cliente dado por su id
        /// </summary>
        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        /// <summary>
        /// Borra un cliente dado por su id
        /// </summary>

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
