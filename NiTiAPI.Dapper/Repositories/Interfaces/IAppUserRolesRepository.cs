﻿using NiTiAPI.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NiTiAPI.Dapper.Repositories.Interfaces
{
    public interface IAppUserRolesRepository
    {
        Task<List<AppUserRolesViewModel>> GetListpUserRoles(int coporationId);

    }
}
