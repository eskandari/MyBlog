using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Blogger.Entity;

namespace Blogger.Respository.Sql
{
    public class SqlContext : DbContext
    {
        public SqlContext():base("name = BloggerConnectionString")
        {}

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

    }
}
