﻿using DbAndRepository.GenericsEFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAndRepository.IRepositories
{
    interface IClientLogsRepository : IGenericsRepository<ClientLogs>
    {
        List<ClientLogs> GetByUser(RegUser user);
    }
}