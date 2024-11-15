namespace GestionPedidos
{
    public class DetallePedido
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal CalcularSubtotal()
        {
            return Cantidad * PrecioUnitario;
        }

    }
}
