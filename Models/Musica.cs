using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySpotify.Models
{
  public class Musica
  {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Artista { get; set; }
    public string Letra { get; set; }

    public string Album { get; set; }
    public string UrlStr { get; set; }
    public string Genero { get; set; }

    [NotMapped]
    public string Regravacao { get; set; }
  }
}