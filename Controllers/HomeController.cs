//using APITester.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Diagnostics;
//using System.Net.Http;
//using System.Security.Cryptography.X509Certificates;
//using System.Text.RegularExpressions;

//namespace APITester.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;

//        public HomeController(ILogger<HomeController> logger)
//        {
//            _logger = logger;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//        public async Task<IActionResult> TestApiAsync()
//        {
//            try
//            {
//                X509Certificate2 cert = new X509Certificate2(Path.Combine(Directory.GetCurrentDirectory(), "Cert", "KIBS_e-Uslugi_2024.p12"), "KIBS_e-Uslugi_2024*08",
//                    X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet);
//                var clientHandler = new HttpClientHandler();
//                clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
//                clientHandler.ClientCertificates.Add(cert);
//                Request.Headers.Add("X-Client-Cert", cert.ToString());
//                var client = new HttpClient(clientHandler);
//                client.DefaultRequestHeaders.Add("X-Client-Cert", Regex.Replace(cert.ToString(), @"\t|\n|\r", ""));
//                var result = client.GetAsync("https://localhost:7201/WeatherForecast").GetAwaiter().GetResult();

//                return View();
//            }
//            catch(Exception ex)
//            {
//                ex.ToString();
//                return View();
//            }
//        }

//    }
//}