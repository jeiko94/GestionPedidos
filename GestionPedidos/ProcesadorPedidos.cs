namespace GestionPedidos
{
    public class ProcesadorPedidos
    {
        private readonly IRepositorioPedidos _repositorioPedidos;
        private readonly INotificador _notificador;
        private readonly IGeneradorFactura _generadorFactura;
        private readonly CalculadoraTotalPedido _calculadoraTotalPedido;

        public ProcesadorPedidos(
            IRepositorioPedidos repositorioPedidos,
            INotificador notificador, 
            IGeneradorFactura generadorFactura,
            CalculadoraTotalPedido calculadoraTotalPedido
            )
        {
            _repositorioPedidos = repositorioPedidos;
            _notificador = notificador;
            _generadorFactura = generadorFactura;
            _calculadoraTotalPedido = calculadoraTotalPedido;
        }

        public void ProcesarPedido(Pedido pedido)
        {
            //Calcular el total del pedido
            decimal total = _calculadoraTotalPedido.CalcularTotal(pedido);

            //Guardar el pedido
            _repositorioPedidos.GuardarPedido(pedido);

            //GenerarFactura
            _generadorFactura.GenerarFactura(pedido);

            //Notificar al cliente
            string mensaje = $"Su pedido ha sido procesado. Total: {total:C} ";
            _notificador.Notificar(pedido.Cliente, mensaje);
        }
    }
}
