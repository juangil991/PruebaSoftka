﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoFront.Data
{
    public class UsersRequest<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
