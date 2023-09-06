﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Models
{
    public class Empolyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Department Department { get; set; }
    }
}
