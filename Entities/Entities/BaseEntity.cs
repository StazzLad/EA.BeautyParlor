using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EA.Entity.Entities
{
    public  abstract class IBaseEntity
    {
        Guid Id { get; set; }
        Guid CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        Guid? UpdatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        byte Status { get; set; }
    }

    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdatedAt { get; set; }

        [Range(0, 2,
             ErrorMessage = "0-2 aralığında değer giriniz.")]
        public byte Status { get; set; }
    }

}
