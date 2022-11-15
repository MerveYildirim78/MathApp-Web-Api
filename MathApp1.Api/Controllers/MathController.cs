using Microsoft.AspNetCore.Mvc;

namespace MathApp1.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("Add")]
        public IActionResult Add(int ilksayi, int ikincisayi)
        {
            return Ok(ilksayi + ikincisayi);
        }

        [HttpGet("Sub")]
        public IActionResult Sub(int ilksayi, int ikincisayi)
        {
            return Ok(ilksayi - ikincisayi);
        }

        [HttpGet("Multiple")]
        public IActionResult Multiple(int ilksayi, int ikincisayi)
        {
            return Ok(ilksayi * ikincisayi);
        }

        [HttpGet("Divide")]
        public IActionResult Divide(int ilksayi, int ikincisayi)
        {
            if(ikincisayi == 0)
            {
                return BadRequest("Sayı 0'a bölünemez. Farklı bir sayı giriniz!!!");
            }
            return Ok(ilksayi / ikincisayi);
        }
    }
}
