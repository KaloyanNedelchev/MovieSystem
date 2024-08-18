using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.DTOs.DirectorDTOs
{
    public class DirectorUpdateDTO : DirectorTemplateDTO
    {
        public int DirectorID { get; set; }
    }
}
