using System;
using System.Collections.Generic;

namespace demoSwaggerCore.Modelos
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string DireccionCalleContato { get; set; }
        public string DireccionNumeroContacto { get; set; }
        public string TipoPersona { get; set; }
        public int? Preferente { get; set; }
        public string Correo { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
    }
}
