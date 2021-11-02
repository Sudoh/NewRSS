﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T>
    {

        void Create(T entity);

        void Delete(int index);

        void Update(int index, T entity);

        void SaveChanges();

        List<T> GetAll();


    }
}
