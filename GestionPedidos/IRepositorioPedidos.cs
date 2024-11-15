namespace GestionPedidos
{
    public interface IRepositorioPedidos
    {
        void GuardarPedido(Pedido pedido);
        Pedido ObtenerPedido(int id);
    }
}


