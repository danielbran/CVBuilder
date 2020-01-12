using CVBuilder.Core.Models;
using System;

namespace CVBuilder.Core
{
    /// <summary>
    /// The CVbuilder Options
    /// </summary>
    public interface ICvOptionalValues : IEducation, IFinishable<CurriculumVitae>
    {
        ICvOptionalValues WithBirthday(DateTime date);
        ICvOptionalValues AddPhoto(string photo);
        ICvOptionalValues WithPublicAppearanceItem(PublicAppearance publicAppearanceItem);
        ICvOptionalValues WithWorkingExperienceItem(WorkingExperience workingExperienceItem);
        ICvOptionalValues WithProjectPortofolioItem(ProjectPortofolio projectPortofolioItem);
        ICvOptionalValues WithTrainingItem(Training trainingItem);
        ICvOptionalValues WithCertificationItem(Certification certificationItem);
        ICvOptionalValues Validate();
    }
}


