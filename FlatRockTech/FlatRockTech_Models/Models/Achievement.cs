using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatRockTech_Models.Models
{
    public  class Achievement
    {
        [ForeignKey("User")]
        public int User_Id { get; set; }
        [ForeignKey("Question")]
        public int Question_Id { get; set; }

        public User User { get; set; }
        public Question Question { get; set; }
        [Required]
        public Answer UsersAnswer { get; set; }
    }
}
