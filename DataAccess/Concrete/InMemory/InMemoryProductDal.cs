using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //InMemoryProductDal with IProductDal implement
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        //Const Method InMemory Product List
        public InMemoryProductDal()
        {
            //oracle,sql,postgresql,mongoDB...
            _products = new List<Product> {
            new Product{ProductID=1,CategoryID=1,ProductName="Beer",UnitPrice=15,UnitsInStock=20},
             new Product{ProductID=2,CategoryID=2,ProductName="Beef",UnitPrice=50,UnitsInStock=30},
              new Product{ProductID=3,CategoryID=2,ProductName="Food",UnitPrice=30,UnitsInStock=50},
               new Product{ProductID=4,CategoryID=1,ProductName="Water",UnitPrice=5,UnitsInStock=100},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);
                _products.Remove(product);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public
        List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryID == categoryId).ToList();
            
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
