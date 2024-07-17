using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrabajoFinalEstructuraDeDatos.Models;
using TrabajoFinalEstructuraDeDatos.Enums;
using TrabajoFinalEstructuraDeDatos.Services;
using System.Linq;

namespace TrabajoFinalEstructuraDeDatos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<Tarea>? _listTareas = DefaultData();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static List<Tarea> DefaultData()
        {
            var seededData = new SeedData();
            return seededData.Seed();
        }


        public IActionResult Index()
        {
            var orderedList = _listTareas.OrderByDescending(t => t.Prioridad == Priority.Urgente)
                .ThenByDescending(t => t.Prioridad == Priority.Alta)
                .ThenBy(t=>t.FechaFinal)
                .ToList();
            return View(orderedList);
        }



        public IActionResult FilterByPriority(Priority priority)
        {
            var list = _listTareas.Where(t => t.Prioridad == priority)
                .OrderBy(t => t.FechaFinal)
                .ToList();
            return View(list);
        }

        public IActionResult FilterByUrgency()
        {
            Queue<Tarea> queue = new Queue<Tarea>();
            var list = _listTareas.Where(t => t.Prioridad == Priority.Urgente).OrderBy(t => t.FechaFinal).ToList();
            list.ForEach(t => queue.Enqueue(t));
            
            return View(queue);
        }

        public IActionResult AddTaskIndex()
        {

            return View(new Tarea());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTaskIndex([Bind("Titulo", "Descripcion", "Prioridad", "Categoria", "FechaFinal")] Tarea tarea)
        {
            tarea.Id = _listTareas.Count + 1;
            tarea.Status = Status.Pendiente;
            tarea.FechaInicio = DateTime.Now;
            tarea.Actualizacion?.Push(new EntidadCambios()
            {
                EstadoEntidad = EstadoEntidad.Agregada,
                FechaCambio = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            });

            _listTareas.Add(tarea);
            return RedirectToAction("Index");
        }

        public IActionResult EliminateTask(int id)
        {
            var item = _listTareas?.FirstOrDefault(item => item.Id == id);
            if (item != null) _listTareas?.Remove(item);

            return RedirectToAction("Index");
        }

        public IActionResult UpdateTask(int id)
        {
            var tarea = _listTareas?.FirstOrDefault(item => item.Id == id);
            return View(tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTask([Bind("Id", "Titulo", "Descripcion", "Prioridad", "Categoria", "FechaFinal")] Tarea tarea)
        {
            var task = _listTareas.FirstOrDefault(t => t.Id == tarea.Id);
            _listTareas.Remove(task);

            task.Titulo = task.Titulo != tarea.Titulo ? tarea.Titulo : task.Titulo;
            task.Descripcion = task.Descripcion != tarea.Descripcion ? tarea.Descripcion : task.Descripcion;
            task.Prioridad = task.Prioridad != tarea.Prioridad ? tarea.Prioridad : task.Prioridad;
            task.Categoria = task.Categoria != tarea.Categoria ? tarea.Categoria : task.Categoria;
            task.FechaFinal = task.FechaFinal != tarea.FechaFinal ? tarea.FechaFinal : task.FechaFinal;
            task.Actualizacion.Push(
                new EntidadCambios()
                {
                    FechaCambio = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                    EstadoEntidad = EstadoEntidad.Actualizada
                }
            );

            _listTareas.Add(task);
            return RedirectToAction("Index");
        }









        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
