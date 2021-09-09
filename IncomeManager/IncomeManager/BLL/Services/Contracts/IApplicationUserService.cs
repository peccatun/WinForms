﻿using BLL.InputModels.ApplicationUser;
using System.Threading.Tasks;

namespace BLL.Services.Contracts
{
    public interface IApplicationUserService
    {
        Task InsertApplicationUserAsync(ApplicationUserInputModel inputModel);
    }
}