using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace LR7.Contollers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string fileName, string firstName, string lastName)
        {
            string content = $"Name: {firstName}\tSurname: {lastName}";
            byte[] byteArray = Encoding.UTF8.GetBytes(content);

            return File(byteArray, "text/plain", $"{fileName}.txt");
        }
    }
}