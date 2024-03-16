using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Tracking.Entities
{
    [Table("MusteriTuruGrubu")]
    public class MusteriTuruGrubu 
    {
        public long Id { get; set; }
        public string GrupAdi { get; set; }
        public int? OdemeTalimatiVerebilir { get; set; }
        public int? TopluMisafirRezervasyonuYapabilir { get; set; }
    }
}
