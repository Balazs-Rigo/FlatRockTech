using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatRockTech_Models.Models
{
    public class Answer
    {
        [Key]
        public int Answer_Id { get; set; }
        [Required]
        public string Author { get; set; }
        [ForeignKey("Question")]

        public int Question_Id { get; set; }
        public Question Question { get; set; }
        [ForeignKey("AnswerType")]
        public int AnswerType_Id { get; set; }
        public AnswerType AnswerType { get; set; }

    }
}
