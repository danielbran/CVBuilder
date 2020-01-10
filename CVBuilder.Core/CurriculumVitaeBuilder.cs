using System.Collections.Generic;

namespace CVBuilder.Core
{
    public class CurriculumVitaeBuilder : IFirstName, ILastName, IPhoneNumber, IEmail, IContactAddress, ILanguage, INationality, IEducation, ICvOptionalValues, IUpdatableBuilder<Address>
    {
        private CurriculumVitae _curriculumVitae;

        private CurriculumVitaeBuilder()
        {
            _curriculumVitae = new CurriculumVitae();
            _curriculumVitae.Educations = new List<Education>();
        }

        public static IFirstName Start()
        {
            return new CurriculumVitaeBuilder();
        }

        public ILastName WithFirstName(string firstName)
        {
            _curriculumVitae.FirstName = firstName;
            return this;
        }

        public IPhoneNumber WithLastName(string lastName)
        {
            _curriculumVitae.LastName = lastName;
            return this;
        }

        public IEmail WithPhoneNumber(string phoneNumber)
        {
            _curriculumVitae.PhoneNumber = phoneNumber;
            return this;
        }

        public IContactAddress WithEmail(string emailAddress)
        {
            _curriculumVitae.EmailAddress = emailAddress;
            return this;
        }

        public ICountry WithAddress()
        {
            _curriculumVitae.Address = _curriculumVitae.Address ?? new Address(); // this will ensure we have the link to cv model.
            return AddressBuilder.Start(this, _curriculumVitae.Address);
        }

        public ILanguage WithAddress(Address address) 
        {
            _curriculumVitae.Address = address;
            return this;
        }

        public INationality WithLanguage(string language)
        {
            _curriculumVitae.Languages.Add(language);
            return this;
        }

        public IEducation WithNationaity(string nationality)
        {
            _curriculumVitae.Nationality = nationality;
            return this;
        }

        public ICvOptionalValues WithEducationItem(Education educationItem)
        {
            _curriculumVitae.Educations.Add(educationItem);
            return this;
        }
        public ICvOptionalValues WithCertificationItem(Certification certificationItem)
        {
            _curriculumVitae.Certifications.Add(certificationItem);
            return this;
        }

        public ICvOptionalValues WithTrainingItem(Training trainingItem)
        {
            _curriculumVitae.Trainings.Add(trainingItem);
            return this;
        }

        public ICvOptionalValues WithProjectPortofolioItem(ProjectPortofolio projectPortofolioItem)
        {
            _curriculumVitae.ProjectsPortofolio.Add(projectPortofolioItem);
            return this;
        }

        public ICvOptionalValues WithWorkingExperienceItem(WorkingExperience workingExperienceItem)
        {
            _curriculumVitae.WorkingExperiences.Add(workingExperienceItem);
            return this;
        }

        public ICvOptionalValues WithPublicAppearanceItem(PublicAppearance publicAppearanceItem)
        {
            _curriculumVitae.PublicAppearances.Add(publicAppearanceItem);
            return this;
        }

        public ICvOptionalValues AddPhoto(string photo)
        {
            _curriculumVitae.PhotoUrl = photo;
            return this;
        }

        public CurriculumVitae Finish()
        {
            return _curriculumVitae;
        }

        public void UpdateParrentBuilder(Address address)
        {
            _curriculumVitae.Address = address;
        }
    }
}
