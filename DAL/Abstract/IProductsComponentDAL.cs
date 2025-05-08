using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Abstract
{
    public interface IProductsComponentDAL
    {
        ProductsComponent? GetById(Guid id);
        int Add(ProductsComponent productsComponent);
        int Update(ProductsComponent productsComponent);
        int Delete(Guid id);
    }
}
