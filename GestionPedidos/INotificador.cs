namespace GestionPedidos
{
    public interface INotificador
    {
        void Notificar(Cliente cliente, string mensaje);
    }
}
