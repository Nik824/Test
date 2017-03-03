using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestData.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public int IdQuestion { get; set; }

    
        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public virtual Question Question { get; set; }
    }
}