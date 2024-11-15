namespace GestionPedidos
{
    public class GeneradorFacturaPDF : IGeneradorFactura
    {
        public void GenerarFactura(Pedido pedido)
        {
            //Logica para generar factura PDF
            Console.WriteLine($"Generando factura PDF para el pedido {pedido.Id} con fecha {pedido.Fecha} ");
        }
    }
}
