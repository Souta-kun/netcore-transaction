namespace ventas.webapi.ApplicationCore.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime Creado { get; set; }
    }
}