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
    public class AboutPageComponentBLL : IAboutPageComponentBLL
    {
        private readonly IAboutPageComponentDAL _dal;
        public AboutPageComponentBLL()
        {
            _dal = new AboutPageComponentDAL();
        }
        public bool Add(AboutPageComponent aboutPageComponent)
        {
            try
            {
                int result = _dal.Add(aboutPageComponent);
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

        public AboutPageComponent? Get(Guid id)
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

        public bool Update(AboutPageComponent aboutPageComponent)
        {
            try
            {
                int result = _dal.Update(aboutPageComponent);
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
