using System;
using System.Collections.Generic;

namespace CVBuilder.Core.Models
{
    public class CurriculumVitae
    {
        public CurriculumVitae(string firstName, string lastName, string phoneNumber, string emailAddress)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

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
}