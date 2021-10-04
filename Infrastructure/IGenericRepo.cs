

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public interface IGenericRepo<T>{
    T Save(T entity);
    T Get(int id);
    IEnumerable<T> GetAll();
    
    IEnumerable<T> Find(Expression< Func<T,bool>> predicate);
    void SaveChanges();
}