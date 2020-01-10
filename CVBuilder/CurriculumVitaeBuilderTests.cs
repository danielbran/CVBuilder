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
        public void Create_CurriculumVitae_Successfully()
        {
            CV.CurriculumVitae curriculum = CVBuilder.Core.CVBuilder
                .Start()
                .WithName("Daniel Bran")
                .WithPhoneNumber("0040734470375")
                .WithEmailAddress("brandanyel@gmail.com")
                .WithAddress("Oradea, Romania")
                .WithEducationItem(new List<CV.Education>
                {
                    new CV.Education(){ Id = 1, Title = "Facultate"},
                    new CV.Education() { Id = 2, Title = "Master" }
                })
                .Finish();

            Assert.AreEqual(curriculum.Name, "Daniel Bran");
            Assert.AreEqual(curriculum.PhoneNumber, "0040734470375");
            Assert.AreEqual(curriculum.EmailAddress, "brandanyel@gmail.com");
            Assert.AreEqual(curriculum.ContactAddress, "Oradea, Romania");
            Assert.IsTrue(curriculum.Educations.ToList().Count == 2);

            Assert.Pass();
        }
    }
}