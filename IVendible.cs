using System;

namespace TiendaOnePiece
{
    // INTERFAZ: Contrato para artículos que registran su venta.
    public interface IVendible
    {
        void ProcesarVenta(int cantidad);
    }
}