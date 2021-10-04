

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    AppDB _db;
    public GenericRepo(AppDB db) => _db = db;

    public T Save(T entity)
    {
        return _db.Add<T>(entity).Entity;
    }

    public T Get(int id)
    {
        return _db.Set<T>().Find(id);
    }

   public IEnumerable<T> GetAll()
    {
        return _db.Set<T>().ToList();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
    {
        return _db.Set<T>().Where(predicate).ToList();
    }

    public void SaveChanges()
    {
        _db.SaveChanges();
    }
}