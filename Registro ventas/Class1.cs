using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_ventas
{
    class RegistradorVentas
    {
        //clonar su atributo, que va a ser de tipo privado
        private int ventas;

        public void registrarVentas() //publico y void porque no debe regresar ningun valor por ahora
        {
            Console.WriteLine("Registro de ventas");

            Console.WriteLine("Ingrese la canidad de ventas realizadas");
            ventas = int.Parse(Console.ReadLine());//se guarda en atributo ventas

            int i;//para crear clico for
            for (i = 1; i <= ventas; i++)//variable acumulativa
            {
                int x;//donde se va a guardar el valor de la venta
                Console.WriteLine("cual fue el valor de la venta?");
                x = int.Parse(Console.ReadLine());
                suma = suma + x; //suma de las ventas que se van a ingresar, para mostrar valor de todas las ventas

                if (x <= 300000) //para cumplir primera condición del ejercicio
                {
                    Console.WriteLine("Se registra una venta menor o igual a $300,000 ");
                }
                else if (x > 300000 && x < 800000)  //para cumplir con la segunda condición del ejercicio
                {
                    Console.WriteLine("Se registra una venta mayor a $300,000 pero menor a $800,000 ");
                }
                else if (x >= 800000)
                {
                    Console.WriteLine("Se registra una venta igual o mayor a $800,000");
                }

                if (x <= 400000)
                {
                    menoresIguales400 = x * 3 / 100;//formula para sacar el porcentaje de comision de acuerdo con la tabla
                    Console.WriteLine("La bonificación correspondiente a la venta es de $" + menoresIguales400);
                }else if (x > 400001 && x < 800000)
                {
                    mayores401Menores800 = x * 5 / 100;
                    Console.WriteLine("La bonificación correspondiente a la venta es de $" + mayores401Menores800);
                }
                else if (x >= 800000)
                {
                    mayoresIguales800 = x * 10 / 100;
                    Console.WriteLine("La bonificación correspondiente a la venta es de $" + mayoresIguales800);
                }
            }
        }
        public int Basico() //el basico de los trabajadores
        {
            int Basico;
            Basico = 500000;
            return Basico;
        }
        int suma = 0; //para conocer el valor total de las ventas
        public int valorTotalVentas()
        {
            int valorTotalVentas = suma;//empezando a ejecutar suma
            Console.WriteLine("El valor de total de las ventas es de $" + valorTotalVentas);
            return valorTotalVentas;
        }

        double menoresIguales400 = 0; //para almacenar el valor de la comision
        double mayores401Menores800 = 0;
        double mayoresIguales800 = 0;

        public double salarioCompleto()
        {
            double salarioCompleto;
            salarioCompleto = menoresIguales400 + mayores401Menores800 + mayoresIguales800 + 500000;
            return salarioCompleto;
        }
        public double totalComisiones()
        {
            double totalComisiones;
            totalComisiones = menoresIguales400 + mayores401Menores800 + mayoresIguales800;
            return totalComisiones;
        }
    }

}
