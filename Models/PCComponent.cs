using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cw7.Models;

public class PCComponent
{
    public int PcId { get; set; }
    
    [ForeignKey(nameof(PcId))]
    public PC PC { get; set; } = null!;

    [MaxLength(10)]
    public string ComponentCode { get; set; } = string.Empty;
    
    [ForeignKey(nameof(ComponentCode))]
    public Component Component { get; set; } = null!;

    public int Amount { get; set; }
}