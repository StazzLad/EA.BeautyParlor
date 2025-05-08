using EA.BLL.Abstract;
using EA.DAL.Abstract;
using EA.DAL.Concrete;
using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.BLL.Concrete
{
    public class ServicesComponentBLL : IServicesComponentBLL
    {
        private readonly IServicesComponentDAL _dal;
        public ServicesComponentBLL()
        {
            _dal = new ServicesComponentDAL();
        }
        public bool Add(ServicesComponent servicesComponent)
        {
            try
            {
                int result = _dal.Add(servicesComponent);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                int result = _dal.Delete(id);
                if (result > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ServicesComponent? Get(Guid id)
        {
            try
            {
                return _dal.GetById(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(ServicesComponent servicesComponent)
        {
            try
            {
                int result = _dal.Update(servicesComponent);
                if (result > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
