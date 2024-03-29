﻿using BLL.InputModels.Category;
using BLL.ViewModels.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.Contracts
{
    public interface ICategoryService
    {
        Task AddCategoryAsync(string inputModel);

        Task<string> GetCategoriesAsync();
    }
}
