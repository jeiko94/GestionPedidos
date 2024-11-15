namespace GestionPedidos
{
    public class Logger
    {
        public void Registrar(string mensaje)
        {
            //Logica para registrar el mensaje (por ejemplo, en un archivo o base de datos)
            Console.WriteLine($"Log: {mensaje}");
        }
    }
}
