namespace MySpotify.Models
{
  public class Album
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Ano { get; set; }
    public string Autor { get; set; }
    public string Part { get; set; }
    public string UrlStr { get; set; }

    public string Genero { get; set; }
  }
}