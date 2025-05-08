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
    [Table(name: "AboutPageComponents")]
    public class AboutPageComponent : BaseEntity
    {
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string LongDescription { get; set; }
        [Required]
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
