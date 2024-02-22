using MusicApi.Models;
using Microsoft.EntityFrameworkCore;
using CourseApi.Models;

namespace MusicApi.Data;

public class MusicContext : DbContext {
    public MusicContext(DbContextOptions<MusicContext> options) : base(options){

    }

    public DbSet<Category> Categories {get;set;}
    public DbSet<Music> Musics {get;set;}

}