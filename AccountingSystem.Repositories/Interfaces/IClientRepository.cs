﻿using System.Collections.Generic;
using AccountingSystem.Models;

namespace AccountingSystem.Repositories.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
    }
}