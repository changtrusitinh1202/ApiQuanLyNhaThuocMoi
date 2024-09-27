using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult GetHihi()
        {
            Random random = new Random();
            List<string> list = new List<string>();
            for(int i = 0; i < 10; i++)
            {
                string date = "HDDHHH" + System.DateTime.Now.ToString("ddMMyyyyhhmmss") + random.Next(1000,9999);
                list.Add(date);
            }
          
            return Ok(list);
        }
    }
}
