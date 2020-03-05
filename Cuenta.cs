using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBanco.Clases
{
    class Cuenta
    {
        public enum listaTipoCuenta { Corriente, Ahorros}
        public enum listaTipoEstado { A, I}
        

        private string nroCuenta;
        private listaTipoEstado estado;
        private listaTipoCuenta tipoCuenta;
        private long saldo;
        private List<Transaccion> movimientos = new List<Transaccion>();


        public Cuenta(listaTipoCuenta tipoCuenta)
        {
            NroCuenta = new Random((int)DateTime.Now.Ticks & 0x0000FFFF).Next(100, 201).ToString() + "-" + new Random((int)DateTime.Now.Ticks & 0x0000FFFF).Next(200, 301).ToString();
            Estado = listaTipoEstado.A;
            TipoCuenta = tipoCuenta;
            saldo = 0;
        }

        public Cuenta(listaTipoCuenta tipoCuenta,long ValorInicial)
        {
            NroCuenta = new Random((int)DateTime.Now.Ticks & 0x0000FFFF).Next(100, 201).ToString() + "-" + new Random((int)DateTime.Now.Ticks & 0x0000FFFF).Next(200, 301).ToString();
            Estado = listaTipoEstado.A;
            TipoCuenta = tipoCuenta;

            if (ValorInicial>=100000) saldo = ValorInicial;
            else throw new Exception("Valor Inicial debe ser mayor a $100.000");

        }

        public string NroCuenta
        {
            get
            {
                return nroCuenta;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length != 7)
                {
                    throw new Exception("Verificar nuemro de cuenta");
                }
                else
                {
                    nroCuenta = value;
                }
            }
        }
        public listaTipoCuenta TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public listaTipoEstado Estado { get => estado; set => estado = value; }
        public long Saldo
        {
            get
            {
                return saldo;
            }
            
        }

        internal List<Transaccion> Movimientos { get => movimientos; set => movimientos = value; }

        public long ModificarSaldo(long valor)
        {
            saldo = saldo + valor;

            return Saldo;
        }
    }
}
