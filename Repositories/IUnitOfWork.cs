﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(); // Asenkron olarak veritabanina kaydetme islemi yapar
    }
}
