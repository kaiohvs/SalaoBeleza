using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalaoBeleza.Models;

namespace SalaoBeleza.Controllers
{
    public class AppointmentController : Controller
    {
        private static List<Appointment> Appointments = new List<Appointment>();

        // Lista de serviços disponíveis
        private static readonly List<SelectListItem> Services = new List<SelectListItem>
        {
            new SelectListItem { Value = "Haircut", Text = "Corte de Cabelo" },
            new SelectListItem { Value = "Manicure", Text = "Manicure" },
            new SelectListItem { Value = "SkinTreatment", Text = "Tratamento de Pele" },
            new SelectListItem { Value = "Pedicure", Text = "Pedicure" },
            new SelectListItem { Value = "HairStraightening", Text = "Progressiva" },
            new SelectListItem { Value = "HairTreatment", Text = "Tratamento Capilar" }
        };

        // Método para exibir o calendário
        public IActionResult Calendar()
        {
            return View();
        }

        // Método para obter os agendamentos
        public JsonResult GetAppointments()
        {
            var events = Appointments.Select(a => new
            {
                title = a.Service + " - " + a.CustomerName,
                start = a.Date.ToString("yyyy-MM-dd") + "T" + a.Time.ToString(@"hh\:mm")
            });

            return new JsonResult(events);
        }

        // Método para criar um novo agendamento
        [HttpGet]
        public IActionResult Create(string date)
        {
            var model = new Appointment
            {
                Date = DateTime.Parse(date)
            };
            ViewBag.Services = new SelectList(Services, "Value", "Text");
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                Appointments.Add(appointment);
                return RedirectToAction("Calendar");
            }
            ViewBag.Services = new SelectList(Services, "Value", "Text");
            return View(appointment);
        }
    }
}
