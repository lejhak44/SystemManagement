﻿using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class _tPropertyType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
    }
}
