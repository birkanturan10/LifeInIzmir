using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using TypeLayer.Cevre;
using TypeLayer.Ulasim;
using TypeLayer.Yasam;

namespace UI.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		//Ulaşım
		public IActionResult Vapurİskeleleri()
		{
            string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/izdeniz/iskeleler");
            var vapur = JsonConvert.DeserializeObject<List<Vapur>>(json);
            return View(vapur);
        }

		public async Task<IActionResult> TaksiDuraklari()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/taksiduraklari";
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var taksi = JsonConvert.DeserializeObject<Taksi>(content);

					return View(taksi.onemliyer);
				}
				else
				{
					return View("Error");
				}
			}
		}

		public async Task<IActionResult> BisimIstasyonlari()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://openapi.izmir.bel.tr/api/izulas/bisim/istasyonlar";
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var bisim = JsonConvert.DeserializeObject<Bisim>(content);

					return View(bisim.stations);
				}
				else
				{
					return View("Error");
				}
			}
		}

		public async Task<IActionResult> OtobusTerminalleri()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/otobusterminalleri";
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var terminal = JsonConvert.DeserializeObject<Terminal>(content);

					return View(terminal.onemliyer);
				}
				else
				{
					return View("Error");
				}
			}
		}

		//Çevre
        public IActionResult SuUretimi()
        {
            string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/izsu/suuretiminindagilimi");
            var su = JsonConvert.DeserializeObject<List<Su>>(json);
            return View(su);
        }

		public IActionResult ArizaKaynakliSuKesintileri()
		{
			string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/izsu/arizakaynaklisukesintileri");
			var su_kesintileri = JsonConvert.DeserializeObject<List<SuKesintileri>>(json);
			return View(su_kesintileri);
		}

		public async Task<IActionResult> KuleAnitveHeykeller()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/kuleanitveheykeller";
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var kule_anit_heykel = JsonConvert.DeserializeObject<KuleAnitHeykel>(content);

					return View(kule_anit_heykel.onemliyer);
				}
				else
				{
					return View("Error");
				}
			}
		}

		public async Task<IActionResult> Muzeler()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/muzeler";
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var muzeler = JsonConvert.DeserializeObject<Muze>(content);

					return View(muzeler.onemliyer);
				}
				else
				{
					return View("Error");
				}
			}
		}

        //Yaşam
        public async Task<IActionResult> SemtPazarYerleri()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/pazaryerleri";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var pazarlar = JsonConvert.DeserializeObject<Pazar>(content);

                    return View(pazarlar.onemliyer);
                }
                else
                {
                    return View("Error");
                }
            }
        }

		public IActionResult KulturSanatEtkinlikleri()
		{
			string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/ibb/kultursanat/etkinlikler");
			var kultur_sanat = JsonConvert.DeserializeObject<List<KulturSanat>>(json);
			return View(kultur_sanat);
		}

		public async Task<IActionResult> TarihiYapilar()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/tarihiyapilar";
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var tarihi = JsonConvert.DeserializeObject<Tarihi>(content);

					return View(tarihi.onemliyer);
				}
				else
				{
					return View("Error");
				}
			}
		}

		public async Task<IActionResult> Universiteler()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/universiteler";
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var universite = JsonConvert.DeserializeObject<Universite>(content);

					return View(universite.onemliyer);
				}
				else
				{
					return View("Error");
				}
			}
		}
	}
}
