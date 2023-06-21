using TreinoAPI.Models.Enuns;

namespace TreinoAPI.Models
{
    public class Exercicio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Repeticao { get; set; }
        public int Execucao { get; set; }
        public int TempoMin { get; set; }
        public ClasseEnum Classe { get; set; }
    }
}