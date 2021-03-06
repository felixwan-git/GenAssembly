﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenAssembly.Descripters
{
    public struct ParameterDescripter
    {
        public ParameterDescripter(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public string Type { get; set; }

        public string Name { get; set; }

    }
}
