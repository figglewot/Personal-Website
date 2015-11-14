using System.Data.Entity;
using PersonalWebsite.Models.Blog;
using PersonalWebsite.Models.Resume;

namespace PersonalWebsite.Models
{
    public class awrightBlogDb : DbContext
    {
        public awrightBlogDb() : base("name=awrightBlogDb")
        {
            
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Certifications> Certifications { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Interests> Interests { get; set; } 
        public DbSet<Skills> Skills { get; set; }

    }
}