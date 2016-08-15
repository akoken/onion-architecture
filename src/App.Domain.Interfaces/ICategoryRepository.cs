using System.Collections.Generic;
using App.Domain.Entities;

namespace App.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
