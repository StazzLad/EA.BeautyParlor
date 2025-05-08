using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.BLL.Abstract
{
    public interface ICategoryComponentBLL
    {
        CategoryComponent? Get(Guid id);
        bool Add(CategoryComponent categoryComponent);
        bool Update(CategoryComponent categoryComponent);
        bool Delete(Guid id);
        
    }
}
