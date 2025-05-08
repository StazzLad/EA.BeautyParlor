using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Entity.Entities
{
    [Table(name: "ServicesComponents")]
    public class ServicesComponent: BaseEntity
    {
        [Required]
        public string TitleDescription { get; set; }
        [Required]
        public string ServiceTitle { get; set; }
        [Required]
        public string ServiceDescription { get; set; }

    }
}
