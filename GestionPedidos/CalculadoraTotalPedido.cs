namespace GestionPedidos
{
    public class CalculadoraTotalPedido
    {
        private readonly IDescuento _descuento;

        public CalculadoraTotalPedido(IDescuento descuento)
        {
            _descuento = descuento;
        }

        public decimal CalcularTotal(Pedido pedido)
        {
            decimal total = 0;

            foreach (var detalle in pedido.Detalles)
            {
                total += detalle.CalcularSubtotal();
            }

            return _descuento != null ? _descuento.AplicarDescuento(total) : total;
        }
    }
}
