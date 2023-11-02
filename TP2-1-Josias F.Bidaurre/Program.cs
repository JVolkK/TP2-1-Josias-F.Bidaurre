using System;

namespace TP2_1_Josias_F.Bidaurre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Patricio Cainzo");
            Cuenta cuenta2 = new Cuenta("Mauro Bringas", 2000);
            Console.WriteLine("La cuenta pertenece a " + cuenta1.Titular + " y contiene: " + cuenta1.Cantidad);
            Console.WriteLine("La cuenta pertenece a " + cuenta2.Titular + " y contiene: " + cuenta2.Cantidad);

            // Ingresa cantidad positiva y se suma a la cantidad existente
            cuenta1.Deposito(4000);
            Console.WriteLine("Se hizo un depósito. La cantidad actual es: " + cuenta1.Cantidad);

            // Ingresa cantidad negativa y la aplicación no hace nada
            cuenta1.Deposito(-4000);
            Console.WriteLine("Se intentó depositar una cantidad negativa. La cantidad actual es: " + cuenta1.Cantidad);

            // Retira una cantidad positiva y se resta a la cantidad existente
            cuenta1.Retiro(500);
            Console.WriteLine("Se hizo un retiro. La cantidad actual es: " + cuenta1.Cantidad);

            // Ingresa una cantidad negativa y no se hace nada
            cuenta1.Retiro(-500);
            Console.WriteLine("Se intentó retirar una cantidad negativa. La cantidad actual es: " + cuenta1.Cantidad);

            // Si la cantidad a retirar es mayor a la cantidad existente, la cuenta queda en 0 como pide el práctico
            cuenta1.Retiro(7000);
            Console.WriteLine("Se intentó retirar una cantidad mayor al saldo. La cantidad actual es: " + cuenta1.Cantidad);

            Console.ReadKey();
        }
    }
}
