using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Tracking.Model
{
    public class AppSettings
    {
        public string DbConnectionString { get; set; }
        public int DbConnectionTimeout { get; set; }

    }
}
