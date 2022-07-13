using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkUpConstruction.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public DateTime RelaseDate { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Profession { get; set; }
        public string Desc { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public List<Comment> Comments { get; set; }
        public List<BlogTag> BlogTags { get; set; }

        public Blog()
        {
            Comments = new List<Comment>();
        }
    }
}
