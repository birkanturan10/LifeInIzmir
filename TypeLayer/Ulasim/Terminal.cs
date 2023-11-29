using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLayer.Ulasim
{
	public class Terminal
	{
        public List<Te> onemliyer { get; set; }
    }

	public class Te
	{
        public string ILCE { get; set; }

        public string MAHALLE { get; set; }

        public string ADI { get; set; }
    }
}
