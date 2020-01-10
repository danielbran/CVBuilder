using System;
using System.Collections.Generic;

namespace CVBuilder.Core
{

    public class CurriculumVitae
    {
        public CurriculumVitae()
        {
            Languages = new HashSet<string>();
            Educations = new List<Education>();
            Certifications = new List<Certification>();
            Trainings = new List<Training>();
            ProjectsPortofolio = new List<ProjectPortofolio>();
            WorkingExperiences = new List<WorkingExperience>();
            PublicAppearances = new List<PublicAppearance>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public Address Address { get; set; }
        public string Nationality { get; set; }
        public DateTime Birthday { get; set; }
        public HashSet<string> Languages { get; set; }
        public string PhotoUrl { get; set; }
        public List<Education> Educations { get; set; }
        public List<Certification> Certifications { get; set; }
        public List<Training> Trainings { get; set; }
        public List<ProjectPortofolio> ProjectsPortofolio { get; set; }
        public List<WorkingExperience> WorkingExperiences { get; set; }
        public List<PublicAppearance> PublicAppearances { get; set; }
    }

    public class Address
    {
        public string Country { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
    }

    public class WorkingExperience : GeneralInfo
    {
        public string Company { get; set; }
        public string Role { get; set; }
        public Period PeriodTime { get; set; }
    }

    public class Education : GeneralInfo
    {
        public string InstitutionName { get; set; }
        public string Recomandation { get; set; }
        public Period PeriodTime { get; set; }
    }

    public class Certification : GeneralInfo
    {
        public string Institution { get; set; }
        public Period PeriodTime { get; set; }
    }

    public class Training : GeneralInfo
    {
        public string Institution { get; set; }
        public Period PeriodTime { get; set; }
    }

    public class ProjectPortofolio : GeneralInfo
    {
        public string ProjectName { get; set; }
        public Period PeriodTime { get; set; }
    }

    public class PublicAppearance : GeneralInfo
    {
        public PublicAppearanceType PublicAppearanceType { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class GeneralInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Period
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public enum PublicAppearanceType
    {
        TV = 0,
        Newspaper = 1
    }
}
