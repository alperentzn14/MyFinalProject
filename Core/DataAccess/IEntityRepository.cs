using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class:referance type
    //IEntity:IEntity or IEntity implementation maybe
    //if IEntity not new 
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        //GetAll Filter Category,product ... with expression func
        List<T> GetAll(Expression<Func<T,bool>>filter=null);

        T Get(Expression<Func<T,bool>>filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
