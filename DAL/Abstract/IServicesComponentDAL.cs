using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Abstract
{
    public interface IServicesComponentDAL
    {
        ServicesComponent? GetById(Guid id);
        int Add(ServicesComponent servicesComponent);
        int Update(ServicesComponent servicesComponent);
        int Delete(Guid id);
    }
}
