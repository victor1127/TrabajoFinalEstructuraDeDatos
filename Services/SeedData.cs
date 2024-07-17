using TrabajoFinalEstructuraDeDatos.Models;
using TrabajoFinalEstructuraDeDatos.Enums;

namespace TrabajoFinalEstructuraDeDatos.Services
{
    public class SeedData
    {
        public List<Tarea> Seed()
        {
            var list = new List<Tarea>()
            {
                new Tarea()
                {
                    Id = 1,
                    Titulo="Implementar un Formulario de Registro de Usuario",
                    Descripcion = "Crea un formulario de registro de usuario en HTML y CSS. " +
                    "Incluye campos para nombre de usuario, correo electrónico, contraseña y confirmación de contraseña. " +
                    "Implementa validaciones básicas en el front-end usando JavaScript para asegurar que los campos no estén vacíos y que la contraseña coincida con la confirmación de contraseña. " +
                    "Opcional: Añade validaciones adicionales como verificar que el correo tenga un formato correcto.",
                    Prioridad = Priority.Urgente,
                    Status = Status.Pendiente,
                    Categoria = Category.Trabajo,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,9,15),
                    Actualizacion = new Stack<EntidadCambios>()
                },
                new Tarea()
                {
                    Id = 2,
                    Titulo="Conectar la Base de Datos con una Aplicación Web",
                    Descripcion = "Configura una base de datos MySQL (o cualquier otra base de datos que se esté usando en el proyecto). " +
                    "Crea una tabla para almacenar la información de los usuarios registrados (id, nombre de usuario, correo, contraseña). " +
                    "Escribe un script en el servidor (usando Node.js, PHP, ASP.NET, etc.) para insertar datos en esta tabla cuando un nuevo usuario se registra. " +
                    "Asegúrate de que las contraseñas se almacenen de manera segura usando hashing.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Trabajo,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,8,10)
                },
                new Tarea()
                {
                    Id = 3,
                    Titulo="Crear una Página de Listado de Productos",
                    Descripcion = "Diseña una página en HTML y CSS que muestre una lista de productos. " +
                    "Los productos deben mostrarse en un formato de cuadrícula con una imagen, nombre, precio y una breve descripción. " +
                    "Implementa la funcionalidad para que los productos se obtengan de una API REST y se muestren dinámicamente en la página usando JavaScript. " +
                    "Usa fetch() para realizar la solicitud a la API y manipular el DOM para mostrar los productos.",
                    Prioridad = Priority.Alta,
                    Status = Status.Pendiente,
                    Categoria = Category.Trabajo,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,10,10)
                },
                new Tarea()
                {
                    Id = 4,
                    Titulo="Añadir Paginación a la Lista de Productos",
                    Descripcion = "Extiende la página de listado de productos para incluir paginación. " +
                    "Implementa botones para navegar entre las diferentes páginas de productos. " +
                    "Asegúrate de que la paginación se realice tanto en el front-end como en el back-end. " +
                    "En el back-end, ajusta la consulta a la base de datos para devolver solo un subconjunto de productos basado en la página actual.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Trabajo,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,10,10)
                },
                new Tarea()
                {
                    Id = 5,
                    Titulo="Escribir Pruebas Unitarias para una Función",
                    Descripcion = "Identifica una función en el código base que sea lo suficientemente aislada para escribir pruebas unitarias (por ejemplo, una función que calcule el precio total de una lista de productos con descuento). " +
                    "Usa un framework de pruebas adecuado (como Jest para JavaScript, NUnit para C#, etc.). " +
                    "Escribe varias pruebas unitarias que verifiquen el comportamiento de la función con diferentes entradas. " +
                    "Asegúrate de que las pruebas cubran casos normales, bordes y casos especiales.",
                    Prioridad = Priority.Alta,
                    Status = Status.Pendiente,
                    Categoria = Category.Trabajo,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,8,20)
                },
                new Tarea()
                {
                    Id = 6,
                    Titulo="Leer un Libro sobre Desarrollo Profesional",
                    Descripcion = "Selecciona un libro relacionado con el desarrollo profesional, liderazgo, o habilidades interpersonales. " +
                    "Dedica al menos 30 minutos al día para leer el libro. " +
                    "Anota los puntos clave y reflexiones personales en un diario o blog.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Personal,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,7,31)
                },
                new Tarea()
                {
                    Id = 7,
                    Titulo="Mejorar las Habilidades de Comunicación",
                    Descripcion = "Inscríbete en un curso online de comunicación efectiva o habilidades de presentación (por ejemplo, en Coursera, Udemy, etc.). " +
                    "Completa los módulos del curso y practica las técnicas aprendidas. Implementa una sesión de práctica donde presentes un tema técnico o de interés personal a tus compañeros de trabajo o amigos.",
                    Prioridad = Priority.Urgente,
                    Status = Status.Pendiente,
                    Categoria = Category.Personal,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,12,31)
                },
                new Tarea()
                {
                    Id = 8,
                    Titulo="Contribuir a un Proyecto de Código Abierto",
                    Descripcion = "Busca un proyecto de código abierto en GitHub que te interese y esté alineado con tus habilidades. " +
                    "Familiarízate con el proyecto y su guía de contribución. Identifica una tarea o issue que puedas resolver. " +
                    "Realiza la contribución y participa en la revisión de código si es necesario.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Personal,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,12,31)
                },
                new Tarea()
                {
                    Id = 9,
                    Titulo="Desarrollar un Proyecto Personal",
                    Descripcion = "Identifica un área de interés o una necesidad personal que pueda ser abordada mediante el desarrollo de software. " +
                    "Define los objetivos y alcance del proyecto personal (por ejemplo, una aplicación móvil, un sitio web, una herramienta de automatización). " +
                    "Divide el proyecto en tareas manejables y crea un plan de acción con plazos. " +
                    "Dedica tiempo regularmente para trabajar en el proyecto y documenta tu progreso. " +
                    "Al finalizar, comparte tu proyecto con otros, ya sea a través de un portafolio en línea, redes sociales, o presentaciones.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Personal,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,8,10)
                },
                new Tarea()
                {
                    Id = 10,
                    Titulo="Desarrollar un Proyecto Personal",
                    Descripcion = "Identifica un área de interés o una necesidad personal que pueda ser abordada mediante el desarrollo de software. " +
                    "Define los objetivos y alcance del proyecto personal (por ejemplo, una aplicación móvil, un sitio web, una herramienta de automatización). " +
                    "Divide el proyecto en tareas manejables y crea un plan de acción con plazos. " +
                    "Dedica tiempo regularmente para trabajar en el proyecto y documenta tu progreso. " +
                    "Al finalizar, comparte tu proyecto con otros, ya sea a través de un portafolio en línea, redes sociales, o presentaciones.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Personal,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,8,10)
                },
                new Tarea()
                {
                    Id = 11,
                    Titulo="Estudiar un Curso Online de Programación",
                    Descripcion = "Elige un curso online gratuito o de pago en una plataforma como Coursera, edX, Udemy, o Khan Academy sobre un lenguaje de programación que te interese o que sea relevante para tus estudios. " +
                    "Dedica al menos una hora al día a ver las lecciones y realizar los ejercicios prácticos.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Estudios,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,11,10)
                },
                new Tarea()
                {
                    Id = 12,
                    Titulo="Practicar Entrevistas Técnicas",
                    Descripcion = "Prepara una lista de preguntas comunes de entrevistas técnicas (algoritmos, estructuras de datos, problemas de lógica, etc.) " +
                    "Programa sesiones de práctica con un compañero de clase o mentor.",
                    Prioridad = Priority.Normal,
                    Status = Status.Pendiente,
                    Categoria = Category.Estudios,
                    FechaInicio = DateTime.Now,
                    FechaFinal = new DateTime(2024,11,10)
                }
            };

            list.ForEach(l => l.Actualizacion?.Push(
                new EntidadCambios()
                {
                    EstadoEntidad = EstadoEntidad.Agregada,
                    FechaCambio = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                }));

            return list;
        }
    }
}
