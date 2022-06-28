using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatRockTech_Models.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
