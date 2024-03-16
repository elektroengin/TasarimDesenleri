using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food.Tracking.Test.Portal.Entities
{
    [Table("Yetki")]
        public class Yetki 
        {
            public long Id { get; set; }
            public string YetkiAdi { get; set; }
            public string YetkiKey { get; set; }
            public short Status { get; set; }
        }
}
