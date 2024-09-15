using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        [HttpGet]
        public string GetHihi()
        {
            return "kkkkk";
        }
    }
}
