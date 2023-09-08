using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Dominio
{
    internal class Cuenta
    {
        public int Cbu { get; set; }
        public double Saldo { get; set; }
        public int TipoCuenta { get; set; }
        public DateTime UltimoMovimiento { get; set; }

        public Cliente Cliente { get; set; }

        public Cuenta(int cbu, double saldo, int tipoCuenta, DateTime ultimoMovimiento, Cliente cliente)
        {

            this.Cbu = cbu;
            this.Saldo = saldo;
            this.TipoCuenta = tipoCuenta;
            this.UltimoMovimiento = ultimoMovimiento;
            this.Cliente = cliente;
        }
    }
}
