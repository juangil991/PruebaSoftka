using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoFront.Data
{
    public class PreguntasRequest<T>
    {
        public string Message { get; set; } // Mensaje de error Backend
        public T Data { get; set; } // respuesta del backend a solicitudes
    }
}
