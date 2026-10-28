using System;

namespace TiendaOnePiece
{
    // CLASE ABSTRACTA: El molde base para toda la mercancía de la tienda.
    public abstract class ArticuloOnePiece
    {
        public string Nombre { get; set; }
        public string Personaje { get; set; }
        public double PrecioBase { get; set; }

        // Método normal heredado
        public void MostrarInfoBase()
        {
            Console.WriteLine($"\n--- {Nombre} (Personaje: {Personaje}) ---");
            Console.WriteLine($"Precio Base: {PrecioBase} Berries");
        }

        // Método abstracto: Obliga a cada artículo a calcular sus propios impuestos o descuentos.
        public abstract double CalcularPrecioFinal();
    }
}