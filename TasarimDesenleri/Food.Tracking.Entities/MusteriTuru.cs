using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Tracking.Entities
{
    [Table("MusteriTuru")]
    public partial class MusteriTuru
    {
        public long Id { get; set; } // ORTAK
        public string TurAdi { get; set; }
        public string TurUzunAdi { get; set; }
        public int MisafirSayisi { get; set; }
        public MusteriTuruGrubu MusteriTuruGrubu { get; set; }
        public int BakiyesizRezervasyon { get; set; }
        public int Burslu { get; set; }
        public int KotadanRezervasyon { get; set; }
        public int KotadanRezervasyonYapabilir { get; set; }
        public DateTime CreatedOn { get; set; } //ORTAK
        public long CreatedBy { get; set; } //ORTAK
        public DateTime? ModifiedOn { get; set; } //ORTAK
        public long? ModifiedBy { get; set; } //ORTAK
    }
}
