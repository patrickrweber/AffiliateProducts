﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffiliateProducts.Domain.DTO.Product
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        public CategoryDTO? Category { get; set; }
    }
}
