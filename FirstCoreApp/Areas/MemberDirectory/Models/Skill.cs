using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstCoreApp.MemberDirectory.Models
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }

        [Required]
        [Display(Name = "Skill Name")]
        public string SkillName { get; set; }
    }
}
