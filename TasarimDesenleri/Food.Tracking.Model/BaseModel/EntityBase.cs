using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food.Tracking.Model.BaseModel
{
    public partial class EntityBase<TId>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TId Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public long CreatedBy { get; set; } 
        public DateTime? ModifiedOn { get; set; } 
        public long? ModifiedBy { get; set; } 

    }
}
