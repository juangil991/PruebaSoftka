﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoFront.Data
{
    public class PreguntasDb
    {
        public int Id { get; set; }
        public string Preguntas { get; set; }
        public int Dificultad { get; set; }
        public int Estado { get; set; }
    }
}
