using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLayer.Ulasim
{
	public class Vapur
	{
		[DisplayName("ID")]
        public int IskeleId { get; set; }

		[DisplayName("İskele Adı")]
		public string Adi { get; set; }

		[DisplayName("Aktif Mi?")]
		public bool AktifMi { get; set; }

		[DisplayName("Arabalı Vapur İskelesi Mi?")]
		public bool ArabaliVapurIskelesiMi { get; set; }
	}
}
