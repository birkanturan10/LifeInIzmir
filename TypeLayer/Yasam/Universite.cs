using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLayer.Yasam
{
    public class Universite
    {
        public List<U> onemliyer { get; set; }
    }

    public class U
    {
        public string ILCE { get; set; }

        public string MAHALLE { get; set; }

        public string ADI { get; set; }

        public string YOL { get; set; }
    }
}
