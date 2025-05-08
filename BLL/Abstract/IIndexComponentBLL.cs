using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.BLL.Abstract
{
    public interface IIndexComponentBLL
    {
        

        bool Add(IndexComponent indexComponent);
        bool Update(IndexComponent indexComponent);
        bool Delete(Guid id);
        IndexComponent? Get(Guid id);
        Task<List<IndexComponent>> GetActiveComponents();
     
        
    }
}
