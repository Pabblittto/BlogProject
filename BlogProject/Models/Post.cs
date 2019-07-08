using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Models
{

    public class BaseContext: DbContext
    {
        public BaseContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

    }



    public class Post
    {
        [Key]
        public int PostId {get;set;}
        [MaxLength(100)]
        public string Title { get; set; }
    }
}
