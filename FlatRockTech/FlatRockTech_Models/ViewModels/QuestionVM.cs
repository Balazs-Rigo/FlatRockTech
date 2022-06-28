using FlatRockTech_Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatRockTech_Models.ViewModels
{
    public class QuestionVM
    {
        public Question Question { get; set; }
        public IEnumerable<SelectListItem> AnswerTypeList { get; set; }

    }
}
