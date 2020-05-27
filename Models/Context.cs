using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MySpotify.Models
{
  public class MySpotifyContext : DbContext
  {
    public DbSet<Musica> Musicas { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Playlist> Playlists { get; set; }

    public DbSet<Album> Albums { get; set; }

    public DbSet<Artista> Artistas { get; set; }

    public DbSet<CadastroUsr> CadastroUsrs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=myspotifytt.db");
  }
}