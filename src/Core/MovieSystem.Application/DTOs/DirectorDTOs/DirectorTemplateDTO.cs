﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.DTOs.DirectorDTOs
{
    public abstract class DirectorTemplateDTO
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        public string Nationality { get; set; }
    }
}
