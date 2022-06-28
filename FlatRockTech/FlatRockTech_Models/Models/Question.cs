using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatRockTech_Models.Models
{
    public class Question
    {
        [Key]
        public int Question_Id { get; set; }
        [MinLength(5,ErrorMessage ="Quote must be longer then 5 character!")]
        [MaxLength(320,ErrorMessage = "Quote must be less then 320 character"!)]
        [Required]
        public string Quote { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
