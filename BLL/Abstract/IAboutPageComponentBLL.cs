using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.BLL.Abstract
{
    public interface IAboutPageComponentBLL 
    {
        AboutPageComponent? Get(Guid id);
        bool Add(AboutPageComponent aboutPageComponent);
        bool Update(AboutPageComponent aboutPageComponent);
        bool Delete(Guid id);

    }
}
