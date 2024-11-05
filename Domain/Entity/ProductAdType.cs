﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductAdType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductAdt> ProductAdts { get; set; }
    }
}
