using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public int Title { get; set; }
        public int Value { get; set; }
    }
}
