namespace APiPagos.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
