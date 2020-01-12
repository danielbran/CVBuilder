using CVBuilder.Core;
using CVBuilder.Core.Models;
using CVBuilder.Core.Printers;
using NUnit.Framework;
using System;

namespace CVBuilder.Tests
{
    public class PrinterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Print_CV_basic_info_into_Console_Successfully()
        {
            // Create Curriculum Vitae using CurriculumVitae builder
            CurriculumVitae curriculum = CVBuilder.Core.CurriculumVitaeBuilder
                .Start()
                .WithFirstName("Daniel")
                .WithLastName("Bran")
                .WithPhoneNumber("0040734***375")
                .WithEmail("bran******@gmail.com")
                .WithAddress()
                .WithCountry("Romania")
                .WithCounty("Bihor")
                .WithCity("Oradea")
                .Update()
                .WithLanguage("English")
                .WithLanguage("Spanish")
                .WithLanguage("Romanian")
                .WithNationaity("Romanian")
                .WithEducationItem(
                    new Education()
                    {
                        Id = 1,
                        Title = "Coumputer Science Faculty",
                        Description = "Coumputer Science Faculty at University of Oradea"
                    })
                .WithEducationItem(
                    new Education()
                    {
                        Id = 2,
                        Title = "Master of Computer Science",
                        Description = "Master of Computer Science at University of Oradea, theme Distributed systems in internet"
                    })
                .WithBirthday(DateTime.Now.AddYears(-18))
                .AddPhoto("https://media-exp1.licdn.com/dms/image/C5103AQGKJtoudXZHSg/profile-displayphoto-shrink_200_200/0?e=1584576000&v=beta&t=B1EuznIzsSR6CEJVoSzXEzIAJudSsIpC8Ky8_EGqBnw")
                .Finish();

            // Create new console printer to display the curriculum into Test output.
            ConsolePrinter consolePrinter = new ConsolePrinter();

            // Print CV into Test output.
            consolePrinter.Print(curriculum);

            // Test asserts
            Assert.AreEqual(curriculum.FullName, "Daniel Bran");
            Assert.AreEqual(curriculum.PhoneNumber, "0040734***375");
            Assert.AreEqual(curriculum.EmailAddress, "bran******@gmail.com");
            Assert.AreEqual(curriculum.Address.Country, "Romania");
            Assert.AreEqual(curriculum.Address.County, "Bihor");
            Assert.AreEqual(curriculum.Address.City, "Oradea");
            Assert.IsTrue(curriculum.Languages.Count == 3);
            Assert.AreEqual(curriculum.Nationality, "Romanian");
            Assert.IsTrue(curriculum.Educations.Count == 2);
            Assert.Pass();
        }

        [Test]
        public void Print_All_CV_info_into_Console_Successfully()
        {
            CurriculumVitae curriculum = CurriculumVitaeBuilder
                .Start()
                .WithFirstName("Daniel")
                .WithLastName("Bran")
                .WithPhoneNumber("0040734***375")
                .WithEmail("bran******@gmail.com")
                .WithAddress(new Address()
                {
                    Country = "Romania",
                    City = "Oradea",
                    County = "Bihor",
                    Street = "private",
                    PostalCode = "private",
                    StreetNumber = "private"
                })
                .WithLanguage("English")
                .WithLanguage("Spanish")
                .WithLanguage("Romanian")
                .WithNationaity("Romanian")
                .WithEducationItem(
                    new Education()
                    {
                        Id = 1,
                        Title = "Coumputer Science Faculty",
                        Description = "Coumputer Science Faculty at University of Oradea"
                    })
                .WithEducationItem(
                    new Education()
                    {
                        Id = 2,
                        Title = "Master of Computer Science",
                        Description = "Master of Computer Science at University of Oradea, theme Distributed systems in internet"
                    })
                .WithBirthday(DateTime.Now.AddYears(-18))
                .WithTrainingItem(new Training()
                {
                    Institution = "Fortech",
                    Title = "Azure Training",
                    Description = "Azure training internal at Fortech with Alex Mang"
                })
                .WithProjectPortofolioItem(
                    new ProjectPortofolio()
                    {
                        Title = "Private Project",
                        Description = "Private description"
                    })
                .WithWorkingExperienceItem(
                    new WorkingExperience()
                    {
                        Title = "Fortech Romania",
                        Description = "I am working at Fortech since 2016"
                    })
                 .WithWorkingExperienceItem(
                    new WorkingExperience()
                    {
                        Title = "Before Fortech",
                        Description = "I was working on several projects for several  Romanian institutions, websites, desktop applications"
                    })
                .WithPublicAppearanceItem(
                    new PublicAppearance()
                    {
                        PublicAppearanceType = PublicAppearanceType.Newspaper,
                        Title = "Mentor at DPIT contest, third place",
                        Description = "My team with me as mentor took the third place DPIT 2019 contest."

                    })
                .WithPublicAppearanceItem(
                    new PublicAppearance()
                    {
                        PublicAppearanceType = PublicAppearanceType.TV,
                        Title = "Mentor at DPIT contest, third place",
                        Description = "My team with me as mentor took the third place DPIT 2019 contest."

                    })
                .AddPhoto("https://media-exp1.licdn.com/dms/image/C5103AQGKJtoudXZHSg/profile-displayphoto-shrink_200_200/0?e=1584576000&v=beta&t=B1EuznIzsSR6CEJVoSzXEzIAJudSsIpC8Ky8_EGqBnw")
                .AddPhoto("http://linkedin/daniel.bran")
                .Validate()
                .Finish();

            // Create new console printer to display the curriculum into Test output.
            ConsolePrinter consolePrinter = new ConsolePrinter();

            // Print CV into Test output.
            consolePrinter.Print(curriculum);

            // Test asserts
            Assert.AreEqual(curriculum.FullName, "Daniel Bran");
            Assert.AreEqual(curriculum.PhoneNumber, "0040734***375");
            Assert.AreEqual(curriculum.EmailAddress, "bran******@gmail.com");
            Assert.AreEqual(curriculum.Address.Country, "Romania");
            Assert.AreEqual(curriculum.Address.County, "Bihor");
            Assert.AreEqual(curriculum.Address.City, "Oradea");
            Assert.IsTrue(curriculum.Languages.Count == 3);
            Assert.AreEqual(curriculum.Nationality, "Romanian");
            Assert.IsTrue(curriculum.Educations.Count == 2);
            Assert.IsTrue(curriculum.Trainings.Count == 1);
            Assert.IsTrue(curriculum.ProjectsPortofolio.Count == 1);
            Assert.IsTrue(curriculum.PublicAppearances.Count == 2);
            Assert.IsTrue(curriculum.WorkingExperiences.Count == 2);
            Assert.Pass();
        }
    }
}
