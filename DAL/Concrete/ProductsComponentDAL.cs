using EA.DAL.Abstract;
using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Concrete
{
    public class ProductsComponentDAL : IProductsComponentDAL
    {
        private readonly BPContext _context;
        public ProductsComponentDAL()
        {
            _context = new BPContext();
        }
        public int Add(ProductsComponent productsComponent)
        {
            _context.ProductsComponents.Add(productsComponent);
            return _context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            _context.ProductsComponents.Remove(_context.ProductsComponents.Find(id));
            return _context.SaveChanges();
        }

        public ProductsComponent? GetById(Guid id)
        {
           return _context.ProductsComponents.Find(id);
        }

        public int Update(ProductsComponent productsComponent)
        {
            _context.ProductsComponents.Update(productsComponent);
            return _context.SaveChanges();
        }
    }
}
