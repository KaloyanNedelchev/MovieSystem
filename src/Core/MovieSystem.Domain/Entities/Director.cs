﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entities
{
    public class Director
    {
        [Key]
        public int DirectorID { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Nationality { get; set; }
    }
}
