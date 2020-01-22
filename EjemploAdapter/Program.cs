using EjemploAdapter.DTO;
using EjemploAdapter.Interface;
using System;
using System.Collections.Generic;

namespace EjemploAdapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adaptado objadaptado = new Adaptado();
            IDatosSucursal objtotalsucursal = new Adaptador(objadaptado);
            Servicio2 objservicio2 = new Servicio2(new DatosJSON());
            List<DatosSucursal> lstdatosSucursales = objservicio2.ObtenerTotal();

            Console.WriteLine(objtotalsucursal.DevuelveDatos());

            Console.WriteLine("Sucursales:");

            foreach (var datos in lstdatosSucursales)
            {
                Console.WriteLine("\n"+"Identificador: " + datos.Id + "   Nombre: " + datos.cSucursal + " Total del día:  " + datos.TotalVentas);
            }           

            Console.ReadLine();
        }
    }
}
