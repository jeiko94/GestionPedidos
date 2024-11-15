namespace GestionPedidos
{
    public class NotificadorEmail : INotificador
    {
        public void Notificar(Cliente cliente, string mensaje)
        {
            //Logica para enviar un email al cliente
            Console.WriteLine($"Enviando Email a {cliente.Nombre}: {mensaje}"); 
        }
    }
}
