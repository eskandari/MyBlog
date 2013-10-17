using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Blogger.Entity
{
    public class UserProfile : EntityBase
    {
        [Required]
        public string EmailAddress { get; set; }

        public string Name { get; set; }
        public string URL { get; set; }
    }
}
