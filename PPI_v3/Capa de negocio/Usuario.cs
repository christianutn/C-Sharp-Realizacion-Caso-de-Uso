using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPI.Capa_de_negocio
{
    public class Usuario
    {
        public bool activo;
        public DateTime fechaIngreso;
        public String nombreUsuario;
        public String password;

        public Usuario (bool activo, DateTime fechaIngreso, string nombreUsuario, string password)
        {
            this.activo = activo;
            this.fechaIngreso = fechaIngreso;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
        }


    }
}
