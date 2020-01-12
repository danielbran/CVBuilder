using CVBuilder.Core.Models;
using CVBuilder.Core.Validators;
using NUnit.Framework;
using System;

namespace CVBuilder.Tests
{
    public class ValidatorTests
    {
        private Core.ICvOptionalValues _curriculum;
        [SetUp]
        public void Setup()
        {
            // Create Curriculum Vitae using CurriculumVitae builder
            _curriculum = CVBuilder.Core.CurriculumVitaeBuilder
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
                .AddPhoto("https://media-exp1.licdn.com/dms/image/C5103AQGKJtoudXZHSg/profile-displayphoto-shrink_200_200/0?e=1584576000&v=beta&t=B1EuznIzsSR6CEJVoSzXEzIAJudSsIpC8Ky8_EGqBnw");
        }

        [Test]
        public void Validate_Valid_CV_Successfully()
        {
            CurriculumVitaeValidator curriculumVitaeValidator = new CurriculumVitaeValidator();

            var validationResult = curriculumVitaeValidator.Validate(_curriculum.Finish());

            // Test asserts
            Assert.IsTrue(validationResult.IsValid);
            Assert.Pass();
        }

        [Test]
        public void Validate_Invalid_CV_Successfully()
        {
            CurriculumVitaeValidator curriculumVitaeValidator = new CurriculumVitaeValidator();

            var validationResult = curriculumVitaeValidator.Validate(_curriculum.WithBirthday(DateTime.Now.AddYears(-17)).Finish());

            // Test asserts
            Assert.IsFalse(validationResult.IsValid);
            Assert.IsTrue(validationResult.Errors.Count > 0);
            Assert.Pass();
        }
    }
}
