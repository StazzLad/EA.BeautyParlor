using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Entity.Entities
{
    [Table(name: "ProductsComponents")]
    public class ProductsComponent: BaseEntity
    {
        [Required]
        [ValidateNever]
        public string ImgUrl { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        [ForeignKey(nameof(CategoryId))]
        public virtual CategoryComponent? CategoryComponent { get; set; }
    }
}
