using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBanco.Clases
{
    class Transaccion
    {
        public enum listaTipoTran { Consignacion, Retiro}

        private DateTime fecha;
        private long valor;
        private listaTipoTran tipoTran;


        public Transaccion(long valor, listaTipoTran tipotran)
        {
            Valor = valor;
            TipoTran = tipotran;
            Fecha = DateTime.Now;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public long Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (value <= 0) throw new Exception("Verificar el valor de la transaccion");
                else valor = value;
            }
        }
        internal listaTipoTran TipoTran { get => tipoTran; set => tipoTran = value; }
    }
}
