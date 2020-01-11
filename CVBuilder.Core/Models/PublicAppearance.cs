using System;

namespace CVBuilder.Core.Models
{
    public class PublicAppearance : GeneralInfo
    {
        public PublicAppearance()
        {
        }

        public PublicAppearance(string title, string description, PublicAppearanceType publicAppearanceType, DateTime date)
        {
            Title = title;
            Description = description;
            PublicAppearanceType = publicAppearanceType;
            DateTime = date;
        }

        public PublicAppearanceType PublicAppearanceType { get; set; }
        public DateTime DateTime { get; set; }
    }
}