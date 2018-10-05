using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _2018OCT05X1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Ange ditt namn")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Ange din email address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="ange ditt nummer")]
        public string Phone { get; set; }



    }
}