using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_3__ingresar_al_sistema.Modelo
{
    public class Trabajador
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string cargo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public Decimal salario { get; set; }
        public string horario { get; set; }
        public int idEmpleado { get; set; }
        public string numeroTelefono { get; set; }
        public const string connectionString = "datasource=34.174.55.147;port=3306;username=vinateria;password=Vinateria123!";
    }
}
