using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class SimplifiedAchievementData
    {
        public List<SimplifiedAchievement> achievements { get; set; }
    }
    public class SimplifiedAchievement
    {
        public int id { get; set; }
        public long completed_timestamp { get; set; }
        public SimplifiedCriterion criteria { get; set; }
    }

    public class SimplifiedCriterion
    {
        public int id { get; set; }
        public bool is_completed { get; set; }
        public int? amount { get; set; }
        public List<SimplifiedCriterionChild>? child_criteria { get; set; }
    }

    public class SimplifiedCriterionChild
    {
        public int id { get; set; }
        public bool is_completed { get; set; }
        public string amount { get; set; }
    }

    public class SimplifiedCharacter
    {
        public List<SimplifiedAchievement> Achievements { get; set; }
    }
}
