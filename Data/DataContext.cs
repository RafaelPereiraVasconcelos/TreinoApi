using Microsoft.EntityFrameworkCore;
using TreinoAPI.Models;
using TreinoAPI.Models.Enuns;

namespace TreinoAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Exercicio> Exercicios { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercicio>().HasData
            (
                new Exercicio() {Id= 1, Nome="Agachamento", Repeticao = 3, Execucao = 12, Classe=ClasseEnum.Perna},
                new Exercicio() {Id= 2, Nome="Supino", Repeticao = 3, Execucao = 15, Classe=ClasseEnum.Peito},
                new Exercicio() {Id= 3, Nome="Prancha", TempoMin = 1, Classe=ClasseEnum.Abdomen},
                new Exercicio() {Id= 4, Nome="Esteira", TempoMin = 30 , Classe=ClasseEnum.Cardio},
                new Exercicio() {Id= 5, Nome="Bíceps Rosca", Repeticao = 4, Execucao = 12, Classe=ClasseEnum.Biceps}
            );
        }
    }
}