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
    [Table(name: "IndexComponents")]
    public class IndexComponent : BaseEntity

    {
        
        [Required]
        [ValidateNever]
        public string ImageUrl { get; set; }
        [ValidateNever]
        public virtual ICollection<IndexComponent> IndexComponents { get; set; } = new HashSet<IndexComponent>();
    }
   
    }
