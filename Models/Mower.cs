﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Models
{
    internal class Mower
    {
        public int MowerId { get; set; }
        public int MowerMakeId { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
    }
}
