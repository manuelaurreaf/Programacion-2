using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBanco.Clases
{
    class Cliente
    {
        public enum listaTipoId { CC, TI, PA, CE }
        private listaTipoId tipoId;
        private string id;
        private string nombre;
        private string nro_Contacto;
        private List<Cuenta> cuentaBanco = new List<Cuenta>();

        public Cliente(listaTipoId tipoId, string id, string nombre, 
            string nro_Contacto)
        {
            try
            {
                Id = id;
                TipoId = tipoId;
                Nombre = nombre;
                Nro_Contacto = nro_Contacto;
            }
            catch (Exception e)
            {
                throw new Exception("Error en el constructor del cliente " + e);
            }
        }

        internal listaTipoId TipoId { get => tipoId; set => tipoId = value; }
        public string Id {
            get
            {
                return id;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new Exception("Verificar el numero del ID");
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Verificar el nombre");
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public string Nro_Contacto
        {
            get
            {
                return nro_Contacto;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)  || (value.Length != 10 && value.Length != 7))
                {
                    throw new Exception("Verificar el numero de contacto");
                }
                else
                {
                    nro_Contacto = value;
                }
            }
        }
        internal List<Cuenta> CuentaBanco { get => cuentaBanco; set => cuentaBanco = value; }

        public string Abrir_Cuenta(Cuenta.listaTipoCuenta tipocuenta)
        {
            try
            {
                Cuenta cuentaNueva = new Cuenta(tipocuenta);
                cuentaBanco.Add(cuentaNueva);
                return "La cuenta abrió exitosamente con el número de cuenta: " + cuentaNueva.NroCuenta + "\n"
                    + "tipo: " + cuentaNueva.TipoCuenta;
            }
            catch (Exception e)
            {
                throw new Exception("Error en el metodo abrir cuenta " + e);
            }

        }
        public bool Cerrar_Cuenta(string NroCuenta)
        {
            try
            {
                bool valido = false;

                foreach (Cuenta i in CuentaBanco)
                {
                    if (i.NroCuenta.Equals(NroCuenta) == true)
                    {
                        if (i.Saldo == 0)
                        {
                            i.Estado = Cuenta.listaTipoEstado.I;
                            valido = true;
                            break;
                        }
                        else valido = false;
                    }
                }

                return valido;
            }
            catch (Exception e)
            {
                throw new Exception("Error en el metodo Cerrar Cuenta " + e);
            }

        }
        public long Consignar(long valor, string nrocuenta)
        {
            try
            {
                long saldocuenta = 0;

                if (valor > 0)
                {
                    foreach (Cuenta i in cuentaBanco)
                    {
                        if ((i.NroCuenta.Equals(nrocuenta) == true) && i.Estado.Equals(Cuenta.listaTipoEstado.A) == true)
                        {
                            Transaccion movimiento = new Transaccion(valor, Transaccion.listaTipoTran.Consignacion);
                            i.Movimientos.Add(movimiento);
                            saldocuenta = i.ModificarSaldo(valor);
                            break;
                        }
                    }
                    return saldocuenta;
                }
                else throw new Exception("Verificar el valor en el metodo consignar");
            }
            catch(Exception e)
            {
                throw new Exception("Error en el metodo Consignar " + e);
            }
        }
        public long Retirar(long valor, string nrocuenta)
        {
            try
            {
                long saldocuenta = 0, valornegado = valor * 2;
                bool encontro = false;

                foreach(Cuenta i in cuentaBanco)
                {
                    if(i.NroCuenta.Equals(nrocuenta) && i.Estado.Equals(Cuenta.listaTipoEstado.A))
                    {
                        if(i.Saldo >= valor)
                        {
                            Transaccion movimiento = new Transaccion(valor, Transaccion.listaTipoTran.Retiro);
                            i.Movimientos.Add(movimiento);
                            i.ModificarSaldo(valor - valornegado);
                            saldocuenta = i.Saldo;
                            encontro = true;
                        }
                        else
                        {
                            throw new Exception("El valor a retirar supera su saldo");
                        } 
                    }
                }
                return saldocuenta;
            }
            catch(Exception e)
            {
                throw new Exception("Error en el metodo retirar");
            }
        }
    }
}
