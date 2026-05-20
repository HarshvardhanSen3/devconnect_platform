using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConnect.Core.Models
{
    public class UserSkill
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SkillName { get; set; } = string.Empty;
        public int YearsOfExperience { get; set; } = 0;

        // Navigation
        public User User { get; set; } = null!;
    }
}
