using EA.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
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
        bool IsActive(Guid id);
        IndexComponent? Get(Guid id);
        Task<List<IndexComponent>> GetActiveComponents();
        IActionResult SetActiveImage(Guid id);

        Task<List<IndexComponent>> GetById();
        Task<IndexComponent> GetByIdAsync(Guid id);




    }
}
