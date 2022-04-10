using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PomeloSoftBlogCaseMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Nancy.Json;
using Microsoft.Extensions.Configuration;
using PomeloSoftBlogCaseMVC.Services;
using Microsoft.AspNetCore.Http;

namespace PomeloSoftBlogCaseMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ITokenService _tokenService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string token = HttpContext.Session.GetString("Token");
            if (token == null)
            {
                ViewBag.Name = "Lütfen Giriş Yaparak JWT Token Edininiz!!!";
                return View();
            }
            else
            {
                ViewBag.Data = GetApiDataOrderByOkunmaSayisi();
                return View();
            }
        }

        [Authorize]
        public List<WebApiModel> GetApiData()
        {
                var apiUrl = "https://localhost:44330/API/GetApiDataList";

                //Connect API
                Uri url = new Uri(apiUrl);
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;

                string json = client.DownloadString(url);
                //END

                //JSON Parse START
                JavaScriptSerializer ser = new JavaScriptSerializer();
                List<WebApiModel> jsonList = ser.Deserialize<List<WebApiModel>>(json);
                //END

                return jsonList;
        }

        public List<WebApiModel> GetApiDataOrderByTarih()
        {
            var apiUrl = "https://localhost:44330/API/GetApiDataListOrderByTarih";

            //Connect API
            Uri url = new Uri(apiUrl);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string json = client.DownloadString(url);
            //END

            //JSON Parse START
            JavaScriptSerializer ser = new JavaScriptSerializer();
            List<WebApiModel> jsonList = ser.Deserialize<List<WebApiModel>>(json);
            //END

            return jsonList;
        }

        public List<WebApiModel> GetApiDataOrderByOkunmaSayisi()
        {
            var apiUrl = "https://localhost:44330/API/GetApiDataListOrderByOkunmaSayisi";

            //Connect API
            Uri url = new Uri(apiUrl);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string json = client.DownloadString(url);
            //END

            //JSON Parse START
            JavaScriptSerializer ser = new JavaScriptSerializer();
            List<WebApiModel> jsonList = ser.Deserialize<List<WebApiModel>>(json);
            //END

            return jsonList;
        }

        public IActionResult ListPage()
        {
            string token = HttpContext.Session.GetString("Token");
            if (token == null)
            {
                ViewBag.Name = "Lütfen Giriş Yaparak JWT Token Edininiz!!!";
                return View();
            }
            else
            {
                ViewBag.Data = GetApiDataOrderByTarih();
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
