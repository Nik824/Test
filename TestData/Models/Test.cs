﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestData.Models
{
    public class Test
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public virtual ICollection<Question> Question { get; set; }

    }
}