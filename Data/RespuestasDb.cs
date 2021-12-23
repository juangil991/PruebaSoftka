using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoFront.Data
{
    public class RespuestasDb
    {
        public int Id { get; set; }
        public string Respuestas { get; set; }
        public int Correcta { get; set; }
        public int IdPregunta { get; set; }
    }
}
