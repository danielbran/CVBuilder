using CVBuilder.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVBuilder.Core.Printers
{
    /// <summary>
    /// Console Printer used to print the CurriculumVitae build with CurriculumVitaeBuilder.
    /// </summary>
    public class ConsolePrinter : PrinterBase<CurriculumVitae>, IPrintable
    {
        private StringBuilder _sb;
        public ConsolePrinter()
        {
            _sb = new StringBuilder();
        }

        /// <summary>
        /// Create the Curriculum structure
        /// </summary>
        /// <param name="message">The message to print</param>
        /// <returns></returns>
        public override string Create(CurriculumVitae message)
        {
            _sb.Append($"Demo CurriculumVitae printed with ConsolePrinter. \n\n");
            _sb.Append($"FullName: {message.FullName}\n\n");
            _sb.Append($"PhoneNumber: {message.PhoneNumber}\n\n");
            _sb.Append($"EmailAddress: {message.EmailAddress}\n\n");
            _sb.Append($"Birthday: {message.Birthday}\n\n");
            _sb.Append($"Languages: {string.Join(",", message.Languages)}\n\n");
            _sb.Append($"Nationality: {message.Nationality}\n\n");
            _sb.Append($"Address: {message.Address.Street}, {message.Address.StreetNumber}, {message.Address.City}, {message.Address.County}, {message.Address.Country}\n\n");
            _sb.Append($"PhotoUrl: {message.PhotoUrl}\n\n");

            if (message.Educations != null && message.Educations.Count > 0)
            {
                _sb.Append("Education: \n\n");

                foreach (var item in message.Educations)
                {
                    _sb.Append($"Title: {item.Title}\n\n");
                    _sb.Append($"Description: {item.Description}\n\n");
                }
            }

            if (message.Trainings != null && message.Trainings.Count > 0)
            {
                _sb.Append("Trainings: \n\n");

                foreach (var item in message.Trainings)
                {
                    _sb.Append($"Title: {item.Title}\n\n");
                    _sb.Append($"Description: {item.Description}\n\n");
                }
            }

            if (message.WorkingExperiences != null && message.WorkingExperiences.Count > 0)
            {
                _sb.Append("Working Experiences\n\n\n");

                foreach (var item in message.WorkingExperiences)
                {
                    _sb.Append($"Title: {item.Title}\n\n");
                    _sb.Append($"Description: {item.Description}\n\n");
                }
            }

            if (message.Certifications != null && message.Certifications.Count < 0)
            {
                _sb.Append("Category \n\n\n");

                foreach (var item in message.Certifications)
                {
                    _sb.Append($"Title: {item.Title}\n\n");
                    _sb.Append($"Description: {item.Description}\n\n");
                }
            }

            if (message.PublicAppearances != null && message.PublicAppearances.Count < 0)
            {
                _sb.Append("Category \n\n\n");

                foreach (var item in message.PublicAppearances)
                {
                    _sb.Append($"Title: {item.Title}\n\n");
                    _sb.Append($"Description: {item.Description}\n\n");
                }
            }

            return _sb.ToString();
        }

        /// <summary>
        /// Get Printer implementation
        /// </summary>
        /// <returns></returns>
        public override IPrintable GetPrinter()
        {
            return this;
        }

        #region IPrintable Console method implementations
        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        #endregion
    }
}
