using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string PostUrl { get; set; }
    }
}
