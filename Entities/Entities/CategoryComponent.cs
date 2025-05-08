using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Entity.Entities
{
    [Table(name: "CategoryComponent")]
    public class CategoryComponent: BaseEntity
    {
        public CategoryComponent() 
        {
            this.ProductsComponent = new HashSet<ProductsComponent>();
        }

        public virtual ICollection<ProductsComponent> ProductsComponent { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
