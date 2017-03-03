using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestData.Models
{
    public class DataContext:DbContext
    {
        public DataContext()
            : base("name=DefaultConnection")
        {

        }

        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Test> Test { get; set; }
    }
}