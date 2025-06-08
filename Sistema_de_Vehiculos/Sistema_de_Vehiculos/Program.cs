using System;

namespace Sistema_de_Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Corolla", "Toyota", 2020);
            carro.MostrarInformacion();
        }
    }

    class Vehiculo
    {
        private string modelo;
        private string marca;
        private int year;
        public Vehiculo(string modelo,string marca, int year)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.year = year;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"El modelo del Carro es {modelo} , la marca es {marca} y el año es {year}");
        }
    }

    class Carro : Vehiculo
    {
        public Carro(string modelo, string marca, int year) : base(modelo,marca, year)
        {
        }
    }
}
