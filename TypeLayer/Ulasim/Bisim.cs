using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLayer.Ulasim
{
	public class Bisim
	{
        public List<B> stations { get; set; }
    }

	public class B
	{
        public string IstasyonAdi { get; set; }

        public int Durumu { get; set; }

        public int Kapasite { get; set; }

        public int BisikletSayisi { get; set; }
    }
}
