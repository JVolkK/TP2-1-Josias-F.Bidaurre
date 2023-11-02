using System;

namespace TP2_1_Josias_F.Bidaurre
{
    internal class Cuenta
    {
        private string _titular;
        private decimal _cantidad;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Cuenta(string titular, decimal cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }

        public Cuenta(string titular) : this(titular, 0)
        {
            // Constructor que llama al otro constructor con 0 como cantidad por defecto.
        }

        public void Deposito(decimal cantidad)
        {
            if (cantidad > 0)
            {
                _cantidad += cantidad;
            }
            // No se hace nada si la cantidad es negativa.
        }

        public void Retiro(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                // No se hace nada si la cantidad es negativa o cero.
                return;
            }

            if (cantidad > _cantidad)
            {
                _cantidad = 0;
            }
            else
            {
                _cantidad -= cantidad;
            }
        }
    }
}
