using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.BLL.Abstract
{
    public interface IProductsComponentBLL
    {
        ProductsComponent? Get(Guid id);
        bool Add(ProductsComponent productsComponent);
        bool Update(ProductsComponent productsComponent);
        bool Delete(Guid id);

    }
}
