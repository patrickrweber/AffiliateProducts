﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffiliateProducts.Domain.DTO.Product
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<ProductDTO>? Products { get; }
    }
}
