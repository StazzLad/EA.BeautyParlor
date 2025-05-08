using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Abstract
{
    public interface ICategoryComponentDAL
    {
        CategoryComponent? GetById(Guid id);
        int Add(CategoryComponent categoryComponent);
        int Update(CategoryComponent categoryComponent);
        int Delete(Guid id);
    }
}
