﻿using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
    interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithCategoryById(int productId);
    }
}