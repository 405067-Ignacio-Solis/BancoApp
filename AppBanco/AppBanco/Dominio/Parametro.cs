using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Dominio
{
    internal class Parametro
    {
        public string Nombre { get; set;}

        public object Valor { get; set; }

        public Parametro(string nombre, object valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
        }
    }
}
