using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result
    {
        public bool Correct { get; set; }  // Si la consulta fue exitosa
        public string ErrorMessage { get; set; }  // Mensaje de error
        public Exception Ex { get; set; } // Detalle del error
        public Object Object { get; set; } // Guardar 1 dato
        public List<object> Objects  { get; set; } // Guardar N datos
    }
}
