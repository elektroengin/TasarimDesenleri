using Food.Tracking.Model.BaseModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food.Tracking.Entities
{
    [Table("MusteriTuru")]
    public partial class MusteriTuru : EntityBase<long>
    {
        public string TurAdi { get; set; }
        public string TurUzunAdi { get; set; }
        public int MisafirSayisi { get; set; }
        public MusteriTuruGrubu MusteriTuruGrubu { get; set; }
        public int BakiyesizRezervasyon { get; set; }
        public int Burslu { get; set; }
        public int KotadanRezervasyon { get; set; }
        public int KotadanRezervasyonYapabilir { get; set; }
    }
}