using System.ComponentModel.DataAnnotations;
using CourseApi.Models;

namespace MusicApi.Models;

public class Music {
    //props

    public int MusicId { get; set; }
    [Required]
    public string? Artist {get;set;}
    [Required]
    public string? Title { get; set; }
    [Required]
    public int Length  { get; set; }
    public int CatId {get; set;}
    public Category? Category {get;set;}
}