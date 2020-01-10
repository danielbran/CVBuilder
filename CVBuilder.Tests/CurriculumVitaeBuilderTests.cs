using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using CV = CVBuilder.Core;

namespace CVBuilder.Tests
{
    public class CurriculumVitaeBuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_CurriculumVitae_Minimum_Information_Successfully()
        {
            CV.CurriculumVitae curriculum = CVBuilder.Core.CVBuilder
                .Start()
                .WithFirstName("Daniel")
                .WithLastName("Bran")
                .WithPhoneNumber("0040734470375")
                .WithEmail("brandanyel@gmail.com")
                .WithAddress(new CV.Address() { })
                .WithLanguage("English")
                .WithLanguage("Spanish")
                .WithLanguage("Romanian")
                .WithNationaity("Romanian")
                .WithEducationItem(new CV.Education() { Id = 1, Title = "Facultate" })
                .Finish();

            Assert.AreEqual(curriculum.FullName, "Daniel Bran");
            Assert.AreEqual(curriculum.PhoneNumber, "0040734470375");
            Assert.AreEqual(curriculum.EmailAddress, "brandanyel@gmail.com");
            Assert.AreEqual(curriculum.Address, "Oradea, Romania");
            Assert.IsTrue(curriculum.Educations.ToList().Count == 2);

            Assert.Pass();
        }

        [Test]
        public void Create_CurriculumVitae_AllData_And_Options_Successfully()
        {
            CV.CurriculumVitae curriculum = CVBuilder.Core.CVBuilder
                .Start()
                .WithFirstName("Daniel")
                .WithLastName("Bran")
                .WithPhoneNumber("0040734470375")
                .WithEmail("brandanyel@gmail.com")
                .WithAddress(new CV.Address() { })
                .WithLanguage("English")
                .WithLanguage("Spanish")
                .WithLanguage("Romanian")
                .WithNationaity("Romanian")
                .WithEducationItem(new CV.Education() { Id = 1, Title = "Facultate" })
                .WithEducationItem(new CV.Education() { Id = 2, Title = "Master" })
                .WithCertificationItem(new CV.Certification() { })
                .WithTrainingItem(new CV.Training() { })
                .WithProjectPortofolioItem(new CV.ProjectPortofolio() { })
                .WithWorkingExperienceItem(new CV.WorkingExperience() { })
                .WithPublicAppearanceItem(new CV.PublicAppearance() { })
                .AddPhoto("http://linkedin/daniel.bran")
                .AddPhoto("http://linkedin/daniel.bran")
                .Finish();

            Assert.AreEqual(curriculum.FullName, "Daniel Bran");
            Assert.AreEqual(curriculum.PhoneNumber, "0040734470375");
            Assert.AreEqual(curriculum.EmailAddress, "brandanyel@gmail.com");
            Assert.AreEqual(curriculum.Address, "Oradea, Romania");
            Assert.IsTrue(curriculum.Educations.ToList().Count == 2);

            Assert.Pass();
        }
    }
}