﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labben
{
    public interface IClock
    {
        int Hour { get; set; }
        int Minute { get; set; }
    }
}
