using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace personalKPI.Core.Model
{
 public   class User
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
