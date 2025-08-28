using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Truco_API.Models
{
    public class Jogador
    {
        [Key]
        public int codJogador { get; set; }
        public string nomeJogador { get; set; }
        public int numeroVitorias{ get; set; }
    }
}
