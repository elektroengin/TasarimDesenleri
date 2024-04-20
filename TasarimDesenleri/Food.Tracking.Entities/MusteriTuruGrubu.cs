using Food.Tracking.Model.BaseModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food.Tracking.Entities
{
    [Table("MusteriTuruGrubu")]
    public class MusteriTuruGrubu : EntityBase<long>
    {
        public string GrupAdi { get; set; }
        public int? OdemeTalimatiVerebilir { get; set; }
        public int? TopluMisafirRezervasyonuYapabilir { get; set; }
    }
}
