using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLayer.Ulasim
{
	public class Taksi
	{
        public List<T> onemliyer { get; set; }
    }

	public class T
	{
		[DisplayName("Durak Adı")]
        public string ADI { get; set; }

		[DisplayName("İlçe")]
		public string ILCE { get; set; }

		[DisplayName("Mahalle")]
		public string MAHALLE { get; set; }

		[DisplayName("Kapı Numarası")]
		public string KAPINO { get; set; }
    }
}
