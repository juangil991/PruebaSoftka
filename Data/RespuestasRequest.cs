using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoFront.Data
{
    public class RespuestasRequest<T>
    {
        public string Message { get; set; } // Mensaje de error 
        public T Data { get; set; } // respuesta a solicitudes del el front

    }
}
