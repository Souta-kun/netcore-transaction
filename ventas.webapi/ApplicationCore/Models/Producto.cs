namespace ventas.webapi.ApplicationCore.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public double Valor { get; set; }
        public DateTime Creado { get; set; }
    }
}