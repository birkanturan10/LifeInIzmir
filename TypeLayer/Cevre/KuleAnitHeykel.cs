using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLayer.Cevre
{
	public class KuleAnitHeykel
	{
        public List<KAH> onemliyer { get; set; }
    }

	public class KAH
	{
        public string ILCE { get; set; }

        public string ACIKLAMA { get; set; }

        public string MAHALLE { get; set; }

        public string ADI { get; set; }

        public string YOL { get; set; }
    }
}
