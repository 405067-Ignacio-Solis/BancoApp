using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Dominio
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Dni { get; set; }

        public Cliente(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }
    }

}
