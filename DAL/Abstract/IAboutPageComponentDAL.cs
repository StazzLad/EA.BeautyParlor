using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Abstract
{
    public interface IAboutPageComponentDAL
    {
        AboutPageComponent? GetById(Guid id);
        int Add(AboutPageComponent aboutPageComponent);
        int Update(AboutPageComponent aboutPageComponent);
        int Delete(Guid id);

    }
}
