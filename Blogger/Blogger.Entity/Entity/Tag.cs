using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Blogger.Entity
{
    public class Tag : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

    }
}
