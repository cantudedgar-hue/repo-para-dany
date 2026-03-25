using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SeguimientoTramites.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EjerciciosController : ControllerBase
    {
        [HttpGet("Cuadrado/{numero:int}")]
        public IActionResult Cuadrado(int numero)
        {
            var resultado = numero * numero;
            return Ok($"{numero} al cuadrado = {resultado}");
        }

        [HttpGet("AreaCuadrado/{lado:int}")]
        public IActionResult AreaCuadrado(int lado)
        {
            var resultado = lado * lado;
            return Ok($"Área del cuadrado: {resultado}");
        }

        [HttpGet("PerimetroCuadrado/{lado:int}")]
        public IActionResult PerimetroCuadrado(int lado)
        {
            var resultado = lado * 4;
            return Ok($"Perímetro del cuadrado: {resultado}");
        }

        [HttpGet("AreaCirculo/{radio:int}")]
        public IActionResult AreaCirculo(int radio)
        {
            var resultado = 3.1416 * (radio * radio);
            return Ok($"Área del círculo: {resultado}");
        }

        [HttpGet("PerimetroCirculo/{radio:int}")]
        public IActionResult PerimetroCirculo(int radio)
        {
            var resultado = 2 * 3.1416 * radio;
            return Ok($"Perímetro del círculo: {resultado}");
        }

        [HttpGet("AreaRectangulo/{baseR:int}/{altura:int}")]
        public IActionResult AreaRectangulo(int baseR, int altura)
        {
            var resultado = baseR * altura;
            return Ok($"Área del rectángulo: {resultado}");
        }

        [HttpGet("AreaTriangulo/{baseT:int}/{altura:int}")]
        public IActionResult AreaTriangulo(int baseT, int altura)
        {
            var resultado = (baseT * altura) / 2;
            return Ok($"Área del triángulo: {resultado}");
        }

        [HttpGet("Porcentaje/{cantidad:int}/{porcentaje:int}")]
        public IActionResult Porcentaje(int cantidad, int porcentaje)
        {
            var resultado = (cantidad * porcentaje) / 100;
            return Ok($"{porcentaje}% de {cantidad} = {resultado}");
        }

        [HttpPost("SumaColeccion")]
        public IActionResult SumaColeccion([FromBody] List<int> Numeros)
        {
            int Suma = Numeros.Sum();

            int CuantosPares = Numeros.Count(n => n % 2 == 0);

            return Ok($"La suma es: {Suma}. Hay {CuantosPares} números pares.");
        }


        [HttpGet("Plakata")]
        public IActionResult Plakata(int cuantos)
        {
            List<string> resultado = new List<string>();

            for (int n = 1; n <= cuantos; n++)
            {
                resultado.Add($"✨ 𝓟𝓵𝓪𝓴𝓪𝓽𝓪 {n} ✨");

                if (n % 3 == 0)
                {
                    resultado.Add("🔥 𝓔𝓼𝓽𝓲𝓵𝓸 𝓼𝓮𝓷𝓼𝓾𝓪𝓵 🔥");
                }
            }

            return Ok(resultado);
        }
    }
}