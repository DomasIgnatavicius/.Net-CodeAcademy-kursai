﻿using P049_LINQ_Extension.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extension.Domain.Interfaces
{
    public interface IHumanFactory
    {
        IEnumerable<Human> Bind();
    }
}
