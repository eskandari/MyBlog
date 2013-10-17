using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blogger.Entity
{
    public abstract class EntityBase
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
