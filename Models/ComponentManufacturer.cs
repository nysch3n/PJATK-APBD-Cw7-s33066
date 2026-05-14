using System.ComponentModel.DataAnnotations;

namespace Cw7.Models;

public class ComponentManufacturer
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Abbreviation { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string FullName { get; set; } = string.Empty;

    public DateTime FoundationDate { get; set; }

    public ICollection<Component> Components { get; set; } = new List<Component>();
}