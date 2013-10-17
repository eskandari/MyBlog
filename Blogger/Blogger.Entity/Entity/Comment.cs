using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Blogger.Entity
{
    public class Comment : EntityBase
    {
        [Required]
        public string Body { get; set; }

        [Required]
        public virtual UserProfile SubmittedBy  { get; set; }
    }
}
