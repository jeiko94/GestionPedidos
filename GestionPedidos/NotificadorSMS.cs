namespace GestionPedidos
{
    public class NotificadorSMS : INotificador
    {
        public void Notificar(Cliente cliente, string mensaje)
        {
            //Logica para enviar un SMS
            Console.WriteLine($"Enviando SMS a {cliente.Nombre}, {mensaje}");
        }
    }
}
