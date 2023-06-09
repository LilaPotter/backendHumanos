namespace Humanos.Models
{
    public class HumanoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Sexo { get; set; } = "";

        public int Edad { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
    }
}