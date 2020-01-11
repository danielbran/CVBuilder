using CVBuilder.Core.Models;
using NUnit.Framework;
using System;
using System.Diagnostics;
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
        public void Create_CurriculumVitae_Minimum_Information_Successfully2()
        {
            Console.WriteLine("This is a test");

            Assert.Pass();
        }

        [Test]
        public void Create_CurriculumVitae_Minimum_Information_Successfully()
        {
            CurriculumVitae curriculum = CVBuilder.Core.CurriculumVitaeBuilder
                .Start()
                .WithFirstName("Daniel")
                .WithLastName("Bran")
                .WithPhoneNumber("004070375")
                .WithEmail("bran@gmail.com")
                .WithAddress()
                .WithCountry("Romania")
                .WithCounty("Bihor")
                .WithCity("Oradea")
                .Update() // this is optional, we can user object reference to update the model.
                .WithLanguage("English")
                .WithLanguage("Spanish")
                .WithLanguage("Romanian")
                .WithNationaity("Romanian")
                .WithEducationItem(new Education() { Id = 1, Title = "Facultate" })
                .Finish();

            Assert.AreEqual(curriculum.FullName, "Daniel Bran");
            Assert.AreEqual(curriculum.PhoneNumber, "00400375");
            Assert.AreEqual(curriculum.EmailAddress, "brandanyel@gmail.com");
            Assert.AreEqual(curriculum.Address, "Oradea, Romania");
            Assert.IsTrue(curriculum.Educations.ToList().Count == 2);

            Assert.Pass();
        }

        [Test]
        public void Create_CurriculumVitae_AllData_And_Options_Successfully()
        {
            CurriculumVitae curriculum = CVBuilder.Core.CurriculumVitaeBuilder
                .Start()
                .WithFirstName("Daniel")
                .WithLastName("Bran")
                .WithPhoneNumber("004470375")
                .WithEmail("bran@gmail.com")
                .WithAddress(new Address() { })
                .WithLanguage("English")
                .WithLanguage("Spanish")
                .WithLanguage("Romanian")
                .WithNationaity("Romanian")
                .WithEducationItem(new Education() { Id = 1, Title = "Facultate" })
                .WithEducationItem(new Education() { Id = 2, Title = "Master" })
                .WithCertificationItem(new Certification() { })
                .WithTrainingItem(new Training() { })
                .WithProjectPortofolioItem(new ProjectPortofolio() { })
                .WithWorkingExperienceItem(new WorkingExperience() { })
                .WithPublicAppearanceItem(new PublicAppearance() { })
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