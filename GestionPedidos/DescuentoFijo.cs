namespace GestionPedidos
{
    public class DescuentoFijo : IDescuento
    {
        private readonly decimal _montoDescuento;

        public DescuentoFijo(decimal montoDescuento)
        {
            _montoDescuento = montoDescuento;
        }

        public decimal AplicarDescuento(decimal total)
        {
            return total - _montoDescuento;
        }
    }
}
