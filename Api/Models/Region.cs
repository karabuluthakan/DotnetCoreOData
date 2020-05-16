using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("regions")]
    public class Region : AddressBase
    {
        [Column("continental_id",Order = 1)]  public int ContinentalId { get; set; }
        [ForeignKey(nameof(ContinentalId))] public virtual Continental Continental { get; set; }
    }
}