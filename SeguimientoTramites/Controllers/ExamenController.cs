using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SeguimientoTramites.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamenController : ControllerBase
    {
        [HttpPost("lista")]
        public IActionResult Ejercicio1([FromBody] List<string> lista_f)
        {
            string vocales = "aeiou";
            int contador = 0;

            foreach (string frase in lista_f)
            {
                foreach (char letra in frase)
                {
                    if (vocales.Contains(letra))
                    {
                        contador += 1;
                    }
                }
            }

            return Ok($"vocales:{contador}");
        }

        [HttpPost("list")]
        public IActionResult Ejercicio2([FromBody] List<string> lista_f)
        {
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;

            foreach (string frase in lista_f)
            {
                foreach (char letra in frase)
                {
                    if (letra == '*')
                    {
                        contador1 += 1;
                    }
                    if (letra == '/')
                    {
                        contador2 += 1;
                    }
                    if (letra == '-')
                    {
                        contador3 += 1;
                    }
                }
            }

            return Ok($"*={contador1} /={contador2} -={contador3}");
        }

    }
}