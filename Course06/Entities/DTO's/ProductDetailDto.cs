﻿using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO_s
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; } 

    }
}
