namespace PetroAtivos324173957.Models
{
    public class Ativo
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Tipo { get; set; } = string.Empty;

        public string Localizacao { get; set; } = string.Empty;

        public double CapacidadeProducao { get; set; }

        public DateTime DataUltimaInspecao { get; set; }

        public bool StatusOperacional { get; set; }
    }
}