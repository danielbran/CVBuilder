namespace CVBuilder.Core.Models
{
    public class WorkingExperience : GeneralInfo
    {
        public string Company { get; set; }
        public string Role { get; set; }
        public Period PeriodTime { get; set; }
    }
}
