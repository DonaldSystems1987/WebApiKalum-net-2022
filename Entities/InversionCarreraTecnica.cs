namespace WebApiKalum.Entities
{
    public class InversionCarreraTecnica
    {
        public string InversionId { get; set; }
        public string CarreraId { get; set; }
        public double MontoInscripcion { get; set; }
        public int NumeroPagos { get; set; }
        public double MontoPagos { get; set; }

        public virtual CarreraTecnica CarreraTecnica { get; set; } //Relacion de muchos a uno, muchas carreras tecnicas a una carrera tecnica
    }
}