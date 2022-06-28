using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatRockTech_Models.Models
{
    public class AnswerType
    {
        [Key]
        public int AnswerType_Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public AnswerTypeEnum AnswerTypeChoice { get; set; }
    }
}
