using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Abstract
{
    public interface IIndexComponentDAL
    {
        IndexComponent? GetById(Guid id);
        int Add(IndexComponent indexComponent);
        int Update(IndexComponent indexComponent);
        int Delete(Guid id);
        bool IsActive(Guid id);
        Task<List<IndexComponent>> GetActiveComponents();
        Task<IndexComponent> GetByIdAsync(Guid id);
    }
}
