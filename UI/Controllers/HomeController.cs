using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using TypeLayer.Ulasim;

namespace UI.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

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
	}
}
