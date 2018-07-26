using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoSwaggerCore.Models
{
    public class Cliente
    {
        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        public String nombre { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public String direccionCalleContato { get; set; }
        public String direccionNumeroContacto { get; set; }
        public String tipoPersona { get; set; }
        public int preferente { get; set;}
        public String correo { get; set; }
        public int pais { get; set; }
        public int estado { get; set; }
        public int municipio { get; set; }
        public int colonia { get; set; }
    }
}
