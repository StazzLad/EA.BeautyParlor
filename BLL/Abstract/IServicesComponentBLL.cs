using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.BLL.Abstract
{
    public interface IServicesComponentBLL
    {
        ServicesComponent? Get(Guid id);
        bool Add(ServicesComponent servicesComponent);
        bool Update(ServicesComponent servicesComponent);
        bool Delete(Guid id);
    }
}
