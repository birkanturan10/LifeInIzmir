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

		//	public async Task<IActionResult> TaksiDuraklari(int page = 1, int pageSize = 10)
		//	{
		//		using (HttpClient client = new HttpClient())
		//		{
		//			string apiUrl = "https://openapi.izmir.bel.tr/api/ibb/cbs/taksiduraklari";
		//			HttpResponseMessage response = await client.GetAsync(apiUrl);

		//			if (response.IsSuccessStatusCode)
		//			{
		//				string content = await response.Content.ReadAsStringAsync();
		//				var apiResponse = JsonConvert.DeserializeObject<Taksi>(content);

		//				// Veri setini sayfalamak için LINQ kullanabilirsiniz
		//				var paginatedData = apiResponse.onemliyer
		//					.Skip((page - 1) * pageSize)
		//					.Take(pageSize)
		//					.ToList();

		//				// Sayfalama bilgilerini view'a ekleyin
		//				ViewBag.PageNumber = page;
		//				ViewBag.TotalPages = (int)Math.Ceiling((double)apiResponse.onemliyer.Count / pageSize);

		//				return View(paginatedData);
		//			}
		//			else
		//			{
		//				return View("Error");
		//			}
		//		}
		//	}
		//
	}
}
