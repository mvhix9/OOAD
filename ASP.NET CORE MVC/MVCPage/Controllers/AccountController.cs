using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCPage.Data;
using MVCPage.Models;

namespace MVCPage.Controllers
{
    public class AccountController : Controller
    {
        private readonly MovieContext _context;
        public AccountController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return View("../Account/Index");
            }
            else
            {
                return View("../Home/index");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Account user)
        {
            string username = user.Username;
            string password = user.Password;
            string usernamesql = _context.Account.Where(u => u.Username == username).Select(u => u.Username).FirstOrDefault();
            string passwordsql = _context.Account.Where(u => u.Username == username).Select(u => u.Password).FirstOrDefault();
            using (MD5 md5hash = MD5.Create())
            {
                if (VerifyMd5Hash(md5hash, password, passwordsql))
                {
                    HttpContext.Session.SetString("Username", username);
                    ViewBag.Password = Convert.ToString(GetMd5hash(md5hash, password));
                    return View("../Home/Index");
                }
                else
                {
                    ViewBag.password = GetMd5hash(md5hash, password);
                    return View();
                }
            }
        }
        public string GetMd5hash(MD5 md5hash, string input)
        {
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public bool VerifyMd5Hash(MD5 md5hash, string input, string hash)
        {
            var hashOfInput = GetMd5hash(md5hash, input);
            if (String.Compare(hash, hashOfInput) == 0)
            {
                return true;
            }
            return false;
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return View("../Account/Index");
        }
    }
}