using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace New_Cycle.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmarContraseña { get; set; }
    }
}