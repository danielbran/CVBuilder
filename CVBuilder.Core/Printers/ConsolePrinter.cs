using CVBuilder.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVBuilder.Core.Printers
{
    public class ConsolePrinter : PrinterBase<CurriculumVitae>, IPrintable
    {
        private StringBuilder _sb;
        public ConsolePrinter()
        {
            _sb = new StringBuilder();
        }

        public override string Create(CurriculumVitae message)
        {
            _sb.Append($"FullName: {message.FullName}\n");
            _sb.Append($"PhoneNumber: {message.PhoneNumber}\n");
            _sb.Append($"EmailAddress: {message.EmailAddress}\n");
            _sb.Append($"Birthday: {message.Birthday}\n");
            _sb.Append($"Languages: {string.Join(",", message.Languages)}");
            _sb.Append($"Nationality: {message.Nationality}");
            _sb.Append($"Address: {message.Address.Street} {message.Address.StreetNumber} {message.Address.City} {message.Address.County} {message.Address.Country}");
            _sb.Append($"PhotoUrl: {message.PhotoUrl}");

            if (message.Educations != null && message.Educations.Count > 0)
            {
                _sb.Append("Educations");

                foreach (var item in message.PublicAppearances)
                {
                    _sb.Append($"Title: {item.Title}");
                    _sb.Append($"Description: {item.Description}");
                }
            }

            if (message.Trainings != null && message.Trainings.Count > 0)
            {
                _sb.Append("Trainings");

                foreach (var item in message.Trainings)
                {
                    _sb.Append($"Title: {item.Title}");
                    _sb.Append($"Description: {item.Description}");
                }
            }

            if (message.WorkingExperiences != null && message.WorkingExperiences.Count > 0)
            {
                _sb.Append("Working Experiences");

                foreach (var item in message.WorkingExperiences)
                {
                    _sb.Append($"Title: {item.Title}");
                    _sb.Append($"Description: {item.Description}");
                }
            }

            if (message.Certifications != null && message.Certifications.Count < 0)
            {
                _sb.Append("Category");

                foreach (var item in message.Certifications)
                {
                    _sb.Append($"Title: {item.Title}");
                    _sb.Append($"Description: {item.Description}");
                }
            }

            if (message.PublicAppearances != null && message.PublicAppearances.Count < 0)
            {
                _sb.Append("Category");

                foreach (var item in message.PublicAppearances)
                {
                    _sb.Append($"Title: {item.Title}");
                    _sb.Append($"Description: {item.Description}");
                }
            }

            return _sb.ToString();
        }

        public override IPrintable GetPrinter()
        {
            return this;
        }

        #region Console methods
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
