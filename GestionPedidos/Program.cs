using GestionPedidos;

class Program
{
    static void Main(string[] args)
    {
        //Crear el cliente
        Cliente cliente = new Cliente
        {
            Id = 1,
            Nombre = "Ramon Valdez",
            Email = "ramon@gmail.com",
            Direccion = "Avenidad siempre viva 123"
        };

        //Crear el pedido
        Pedido pedido = new Pedido
        {
            Id = 1001,
            Fecha = DateTime.UtcNow,
            Cliente = cliente,
        };

        //Agregar detalles al pedido
        pedido.Detalles.Add(new DetallePedido
        {
            ProductoId = 1,
            NombreProducto = "Laptop",
            Cantidad = 1,
            PrecioUnitario = 1599m
        });

        pedido.Detalles.Add(new DetallePedido
        {
            ProductoId = 2,
            NombreProducto = "Iphone 16",
            Cantidad = 1,
            PrecioUnitario = 1500m
        });

        //Configurar los servicios
        IDescuento descuento = new DescuentoPorcentaje(10); //10% de descuento
        CalculadoraTotalPedido calculadoraTotal = new CalculadoraTotalPedido(descuento);
        IRepositorioPedidos repositorioPedidos = new RepositorioPedidos();
        INotificador notificador = new NotificadorEmail();
        INotificador notificador1 = new NotificadorSMS();
        IGeneradorFactura generadorFactura = new GeneradorFacturaPDF();
        IDescuento descuento1 = new DescuentoPorCantidad(1000,500); //Descuento de %50 si el total supera $1000

        //Crear el procesador de pedidos
        ProcesadorPedidos procesador = new ProcesadorPedidos(
            repositorioPedidos,
            notificador,
            generadorFactura,
            calculadoraTotal
        );

        //Procesar el pedido
        procesador.ProcesarPedido(pedido);
    }
}