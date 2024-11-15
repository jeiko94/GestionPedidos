namespace GestionPedidos
{
    public class RepositorioPedidos : IRepositorioPedidos
    {
        public void GuardarPedido(Pedido pedido)
        {
            //Logica para guardar el pedido en la base de datos
        }

        public Pedido ObtenerPedido(int id)
        {
            //Lógica para obtener el pedido de la base de datos
            return new Pedido();
        }
    }
}
