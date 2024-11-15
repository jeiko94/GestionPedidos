namespace GestionPedidos
{
    public class DescuentoPorCantidad :  IDescuento
    {
        private readonly int _cantidadMinima;
        private readonly decimal _montoDescuento;

        public DescuentoPorCantidad(int cantidadMinima, decimal montoDescuento)
        {
            _cantidadMinima = cantidadMinima;
            _montoDescuento = montoDescuento;
        }

        public decimal AplicarDescuento(decimal total)
        {
            //Supongamos que si el total supera cierta cantidad, aplicamos el descuento
            return total >= _cantidadMinima ? total - _montoDescuento : total;
        }
    }
}
