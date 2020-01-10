using System.Collections.Generic;

namespace CVBuilder.Core
{
    public interface IFirstName
    {
        ILastName WithFirstName(string name);
    }

    public interface ILastName
    {
        IPhoneNumber WithLastName(string name);
    }

    public interface IPhoneNumber
    {
        IEmail WithPhoneNumber(string phoneNumber);
    }

    public interface IEmail
    {
        IContactAddress WithEmail(string emailAddress);
    }

    public interface IContactAddress
    {
        ICountry WithAddress();
        ILanguage WithAddress(Address address);
    }

    public interface ILanguage
    {
        INationality  WithLanguage(string language);
    }

    public interface INationality : ILanguage
    {
        IEducation WithNationaity(string nationality);
    }

    public interface IEducation 
    {
        ICvOptionalValues WithEducationItem(Education educationItem);
    }

    public interface ICvOptionalValues : IEducation, IFinishable<CurriculumVitae>
    {
        ICvOptionalValues AddPhoto(string photo);
        ICvOptionalValues WithPublicAppearanceItem(PublicAppearance publicAppearanceItem);
        ICvOptionalValues WithWorkingExperienceItem(WorkingExperience workingExperienceItem);
        ICvOptionalValues WithProjectPortofolioItem(ProjectPortofolio projectPortofolioItem);
        ICvOptionalValues WithTrainingItem(Training trainingItem);
        ICvOptionalValues WithCertificationItem(Certification certificationItem);
    }

    public interface IFinishable<T>
        where T : class
    {
        T Finish();
    }

    public interface IUpdatableBuilder<T>
        where T : class
    {
        void UpdateParrentBuilder(T model);
    }
}


