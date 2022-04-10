using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PomeloSoftBlogCaseMVC.Models;
using PomeloSoftBlogCaseMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PomeloSoftBlogCaseMVC.Controllers
{
    public class SecurityController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;

        PomelosoftBlogCaseContext db = new PomelosoftBlogCaseContext();
        public IActionResult Login()
        {
            return View();
        }
        public SecurityController(IConfiguration config, ITokenService tokenService)
        {
            _config = config;
            _tokenService = tokenService;
        }

        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        public IActionResult Login(string userName, string password , string passwordHash)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                ViewBag.Name = "Alanlar Boş Bırakılamaz!!!";
                return View();
            }
            else {
                var user = db.TblKullanici.Where(x => x.KullaniciNickName == userName);

                passwordHash = user.Select(u => u.KullaniciParola).FirstOrDefault();

                bool verified = BCrypt.Net.BCrypt.Verify(password, passwordHash);

                var userr = db.TblKullanici.Where(x => x.KullaniciNickName == userName).FirstOrDefault();
                IActionResult response = Unauthorized();
                var validUser = userr;

                if (validUser != null || BCrypt.Net.BCrypt.Verify(password, passwordHash))
                {
                    generatedToken = _tokenService.BuildToken(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), validUser);
                    if (generatedToken != null)
                    {
                        HttpContext.Session.SetString("Token", generatedToken);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return (RedirectToAction("Error"));
                    }
                }
                else
                {
                    return (RedirectToAction("Error"));
                }
            }

            return View();
        }
        [HttpPost]
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstName, string lastName, string userName, string password) 
        {
            var user = db.TblKullanici.Any(x => x.KullaniciNickName == userName);
            if (user == true)
            {
                ViewBag.Name = "Bu Kullanıcı Adı Sistemde Mevcuttur.";
                return View();
            }
            else
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                ViewBag.Name = "Alanlar Boş Bırakılamaz!";
                return View();
            }
            else
            if (password.Length < 6 || password.Length > 12)
            {
                ViewBag.Name = "Parola 12 haneden büyük veya 6 haneden küçük olamaz.";
                return View();
            }
            else
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                TblKullanici kullanici = new TblKullanici();
                kullanici.KullaniciAdi = firstName;
                kullanici.KullaniciSoyadi = lastName;
                kullanici.KullaniciNickName = userName;
                kullanici.KullaniciParola = passwordHash;

                db.TblKullanici.Add(kullanici);
                db.SaveChanges();

                ViewBag.Name = "Kullanıcı Başarı İle Eklendi.";
            }

            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
