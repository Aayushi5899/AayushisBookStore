using AayushisBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AayushisBooks.DataAccess.Repository
{
    T Get(int id);

    IEnumerable<T> GetAll(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> oderBy = null,
        string includeProperties = null
        );

    T GetFirstOrDefault(
        Expression<Func<T, bool>> filter = null,
        string includeProperties = null
        );

    void Add(T entity); //to add an entity
    void Remove(int id);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entity);
    }
}
