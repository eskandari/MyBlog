using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blogger.Entity
{
    public class Post : EntityBase
    {
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        public DateTime PublishedDate { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        
        [Required]
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
