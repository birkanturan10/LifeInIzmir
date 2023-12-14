using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLayer.Yasam
{
    public class Pazar
    {
        public List<P> onemliyer { get; set; }
    }

    public class P
    {
        public string ILCE { get; set; }

        public string ACIKLAMA { get; set; }

        public string MAHALLE { get; set; }

        public string ADI { get; set; }

        public string YOL { get; set; }
    }
}
