using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NBILicenseProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace NBILicenseProjectMVC.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        private readonly string _apiUrl;
        public static HttpClient Client = null;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
            _apiUrl = _config.GetValue<string>("WebApiUrl");
            
            if (Client == null)
            {
                Client = new HttpClient();
                Client.Timeout = TimeSpan.FromSeconds(_config.GetValue<int>("WebApiTimeOut"));
                Client.BaseAddress = new Uri(_apiUrl);
            }
        }

        public IActionResult Index()
        {
            // return View();
            IList<Applicant> listapplicants = null;
            
            try
            {
                var responseTask = Client.GetAsync("api/Applicant");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Applicant>>();
                    readTask.Wait();
                    listapplicants = readTask.Result; 
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return BadRequest("Application Error");
                return View("BadRequest");
            }
            return View(listapplicants);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }
}
