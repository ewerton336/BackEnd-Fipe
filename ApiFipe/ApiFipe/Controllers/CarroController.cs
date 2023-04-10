using ApiFipe.Domain.Fabricante.Carros;
using ApiFipe.DTO.ListaFipe;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace ApiFipe.Controllers
{
    public class CarroController : Controller
    {
        // GET: CarroController
        public IActionResult Index()
        {
            try
            {
                var ListaFipe = ListaFipeDTO.GetListaCarros();
                var json = JsonConvert.SerializeObject(ListaFipe);
                return Content(json, "application/json");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: CarroController/Details/5
        public IActionResult Details(int idCarro)
        {
            try
            {
                var carro = ListaFipeDTO.GetCarroDetails(idCarro);
                var json = JsonConvert.SerializeObject(carro);
                return Content(json, "application/json");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // POST: CarroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] Carro carro)
        {
            try
            {
                var ListaFipe = ListaFipeDTO.AddCarro(carro);
                var json = JsonConvert.SerializeObject(ListaFipe);
                return Content(json, "application/json");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: CarroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromBody] Carro carro)
        {
            try
            {
                var ListaFipe = ListaFipeDTO.EditCarro(carro);
                var json = JsonConvert.SerializeObject(ListaFipe);
                return Content(json, "application/json");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: CarroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromBody] Carro carro)
        {
            try
            {
                var ListaFipe = ListaFipeDTO.RemoveCarro(carro);
                var json = JsonConvert.SerializeObject(ListaFipe);
                return Content(json, "application/json");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
