using EA.DAL.Abstract;
using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Concrete
{
    public class CategoryComponenetDAL : ICategoryComponentDAL
    {
        private readonly BPContext _context;
        public CategoryComponenetDAL()
        {
            _context = new BPContext();
        }
        public int Add(CategoryComponent categoryComponent)
        {
            _context.CategoryComponents.Add(categoryComponent);
            return _context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            _context.CategoryComponents.Remove(_context.CategoryComponents.Find(id));
            return _context.SaveChanges();
        }

        public CategoryComponent? GetById(Guid id)
        {
           return _context.CategoryComponents.Find(id);
        }

        public int Update(CategoryComponent categoryComponent)
        {
            _context.CategoryComponents.Update(categoryComponent);
            return _context.SaveChanges();
        }
    }
}
