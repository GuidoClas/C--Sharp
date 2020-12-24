using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Lavaderos
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero l1 = new Lavadero(200, 150, 300);

            Vehiculo auto1 = new Auto("AAA111", 4, eMarca.Fiat, 4);
            Vehiculo camion1 = new Camion("BBB222", 6, eMarca.Ford, 55);
            Vehiculo moto1 = new Moto("CCC333", 2, eMarca.Zanella, (float)30.2);
            Vehiculo auto2 = new Auto("DDD444", 4, eMarca.Ford, 4);
            Vehiculo auto3 = new Auto("EEE555", 4, eMarca.Honda, 5);
            Vehiculo camion2 = new Camion("AAA222", 4, eMarca.Scania, 30);

            l1 += auto1;
            l1 += camion1;
            l1 += moto1;
            l1 += auto1;

            Console.WriteLine(l1.Lavaderoo);

            Console.WriteLine("Total facturado: {0}", l1.MostrarTotalFacturado());
            Console.WriteLine("Total facturado Autos: {0}", l1.MostrarTotalFacturado(eVehiculos.Auto));
            Console.WriteLine("Total facturado Camiones: {0}", l1.MostrarTotalFacturado(eVehiculos.Camion));
            Console.WriteLine("Total facturado Motos: {0}", l1.MostrarTotalFacturado(eVehiculos.Moto));

            l1 += auto2;
            l1 += auto3;
            l1 += camion2;
            l1 -= auto1;

            Console.WriteLine(l1.Lavaderoo);

            Console.WriteLine("Total facturado: {0}", l1.MostrarTotalFacturado());
            Console.WriteLine("Total facturado Autos: {0}", l1.MostrarTotalFacturado(eVehiculos.Auto));
            Console.WriteLine("Total facturado Camiones: {0}", l1.MostrarTotalFacturado(eVehiculos.Camion));
            Console.WriteLine("Total facturado Motos: {0}", l1.MostrarTotalFacturado(eVehiculos.Moto));

            l1.OrdenarPorMarca();
            Console.WriteLine("ORDENADOS POR MARCA");
            Console.WriteLine(l1.Lavaderoo);


            l1.OrdenarPorPatente();
            Console.WriteLine("ORDENADOS POR PATENTE");
            Console.WriteLine(l1.Lavaderoo);


            Console.ReadLine();
        }
    }
}
