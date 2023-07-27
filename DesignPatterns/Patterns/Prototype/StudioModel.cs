﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Prototype
{
    public abstract class StudioModel
    {
        public abstract StudioModel Clone();
    }
}
