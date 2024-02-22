using System.ComponentModel.DataAnnotations;
using MusicApi.Models;

namespace CourseApi.Models;

public class Category {
    // props
    public int CatId { get; set; }
    [Required]
    public string? CatName { get; set; }

    public List<Music>? Musics {get;set;}


}
