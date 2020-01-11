using CVBuilder.Core.Models;

namespace CVBuilder.Core
{
    public interface ICvOptionalValues : IEducation, IFinishable<CurriculumVitae>
    {
        ICvOptionalValues AddPhoto(string photo);
        ICvOptionalValues WithPublicAppearanceItem(PublicAppearance publicAppearanceItem);
        ICvOptionalValues WithWorkingExperienceItem(WorkingExperience workingExperienceItem);
        ICvOptionalValues WithProjectPortofolioItem(ProjectPortofolio projectPortofolioItem);
        ICvOptionalValues WithTrainingItem(Training trainingItem);
        ICvOptionalValues WithCertificationItem(Certification certificationItem);
    }
}


