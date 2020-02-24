using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extracto.Clases
{
    class Extracto
    {
        private string Nombre;
        private UInt16 NroId;
        private UInt64 Telefono;
        private UInt16 SaldoPuntos;

        public string nombre
        {
            get { return Nombre.ToUpper(); }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new Exception("Nombre ingresado invalido");
                }

            }
        }
        public ushort nroId
        {
            get { return NroId; }
            set
            {
                if (value > 0)
                {
                    NroId = value;
                }
                else throw new Exception("Numero de ID no es valido");

            }
        }
        public ulong telefono
        {
            get { return telefono; }
            set
            {
                if (value > 999999 && value <= 9999999999)
                {
                    telefono = value;
                }
                else throw new Exception("Numero de ID no es valido");

            }
        }
        public ushort saldoPuntos { get => SaldoPuntos; set => SaldoPuntos = value; }

        public Extracto(string nombre, ushort nroId, ulong telefono)
        {
            try
            {
                Nombre = nombre;
                NroId = nroId;
                Telefono = telefono;
            }
            catch (Exception)
            {
                throw new Exception("Porblema al crear el objeto");
            }
        }
        public ulong AcumularPuntos(ulong ValorCompra)
        {
            ulong ValorAcumulado = 0;
            try
            {
                if (ValorCompra >= 100) ValorAcumulado = ValorCompra % 100;
                return ValorAcumulado;
            }
            catch (Exception)
            {
                throw new Exception("Porblema al crear el objeto");
            }
        }
        public bool RedimirPuntos(ulong Puntos)
        {
            //bool Redimir = false;
            try
            {
                if (SaldoPuntos >= Puntos)
                {
                    SaldoPuntos -= (ushort)Puntos;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw new Exception("No se puede redimir los puntos");
            }
        }

    }
}
