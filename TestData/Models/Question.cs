using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestData.Models
{
    public class Question
    {

        public int Id { get; set; }

      
        public string Text { get; set; }

        public int TestId { get; set; }

        public virtual IList<Answer> Answer { get; set; }

        public virtual Test Test { get; set; }
    }
}