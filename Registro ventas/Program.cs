using System;

namespace Registro_ventas
///Jorge Esteban Dawson Castillo
///140
///Ingenieria Multimedia
///La empresa de tecnología “COMPUTRONIC”, es una empresa líder en venta y distribución de equipos tecnológicos en la ciudad de Bogotá 
///y cuenta en su única sede con un N cantidad de empleados quienes realizan N ventas durante el día. La empresa requiere identificar cuántas 
///de las ventas fueron menores o iguales a $300.000, cuántas ventas fueron mayores a $ 300.000 y menores a $800.000 y cuántas fueron mayores 
///o iguales a $800.000 por cada empleado.
///También se necesita conocer monto total por la venta realizada por empleado y las bonificaciones a pagar según la venta realizada. 
///Para el pago de la bonificación es necesario tener en cuenta la siguiente tabla:
///+------------------------------------------------------+
///| ventas > $400.000     |            3%                |
///|-----------------------|------------------------------|
///| $400.001 - $800.000   |            5%                |
///|-----------------------|------------------------------|
///| ventas > $800.000     |            10%               |
///+-----------------------+------------------------------+
///
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistradorVentas objregistradorVentas;
            objregistradorVentas = new RegistradorVentas();

            objregistradorVentas.registrarVentas();
            objregistradorVentas.valorTotalVentas();

            Console.WriteLine("El basico es de $" + objregistradorVentas.Basico());

            Console.WriteLine("El valor total de las comisiones es de $" + objregistradorVentas.totalComisiones());

            Console.WriteLine("El salario total de basico + comisiones es de $" + objregistradorVentas.salarioCompleto());


            Console.ReadKey();
        }
    }
}
