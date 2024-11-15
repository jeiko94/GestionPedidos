namespace GestionPedidos
{
    public class DescuentoPorcentaje : IDescuento
    {
        private readonly decimal _porcentaje;

        public DescuentoPorcentaje(decimal porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public decimal AplicarDescuento(decimal total)
        {
            return total - (total * _porcentaje / 100);
        }
    }
}
