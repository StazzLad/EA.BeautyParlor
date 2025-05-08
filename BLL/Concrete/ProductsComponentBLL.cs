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
    public class ProductsComponentBLL : IProductsComponentBLL
    {
        private readonly IProductsComponentDAL _dal;
        public ProductsComponentBLL()
        {
            _dal = new ProductsComponentDAL();
        }
        public bool Add(ProductsComponent productsComponent)
        {
            try
            {
                int result = _dal.Add(productsComponent);
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

        public ProductsComponent? Get(Guid id)
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

        public bool Update(ProductsComponent productsComponent)
        {
            try
            {
                int result = _dal.Update(productsComponent);
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
