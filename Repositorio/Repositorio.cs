using System.Collections.Generic;
using MySpotify.Models;

namespace MySpotify.Repositorio
{
  public class Repositorio
  {
    protected MySpotifyContext contexto;

    public Repositorio()
    {
      this.contexto = new MySpotifyContext();
    }

    public void IncluirMusica(Musica musica)
    {
      contexto.Add(musica);
      contexto.SaveChanges();
    }

    public bool ExcluirMusica(int musica_id)
    {
      return true;
    }

    public List<Musica> Listar()
    {
      return null;
    }

    public List<Musica> PesquisarPorGenero()
    {
      return null;
    }

    public List<Musica> PesquisarPorArtistas(string artista)
    {
      return null;
    }

    public List<Musica> PesquisarPorAlbum(string album)
    {
      return null;
    }

    public bool Atualizar(int Id, Musica musica)
    {
      return true;
    }
  }
}