using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductsById(int categoryId);
    }
}
