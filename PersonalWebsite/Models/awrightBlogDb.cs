using System.Data.Entity;

namespace PersonalWebsite.Models
{
    public class awrightBlogDb : DbContext
    {
        public awrightBlogDb() : base("name=awrightBlogDb")
        {
            
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}