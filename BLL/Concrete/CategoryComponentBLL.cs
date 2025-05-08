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
    internal class CategoryComponentBLL : ICategoryComponentBLL
    {
        private readonly ICategoryComponentDAL _dal;
        public CategoryComponentBLL()
        {
            _dal = new CategoryComponenetDAL();
        }

        public bool Add(CategoryComponent categoryComponent)
        {
            
            try
            {
                int result = _dal.Add(categoryComponent);
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

        public CategoryComponent? Get(Guid id)
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

        public bool Update(CategoryComponent categoryComponent)
        {
            try
            {
                int result = _dal.Update(categoryComponent);
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
