
using System;

namespace Resumes.Models
{
    public class Education
    {
        private string _institution;
        private string _degree;
        private int _startYear;
        private int? _endYear;
        private string _location;

        public Education(
            string institution,
            string degree,
            int startYear,
            int? endYear,
            string location)
        {
            _institution = institution;
            _degree = degree;
            _startYear = startYear;
            _endYear = endYear;
            _location = location;
        }

        public void DisplayEducation()
        {
            Console.WriteLine(ToText());
        }

        public string ToText()
        {
            string endYear = _endYear?.ToString() ?? "Present";

            return $"{_degree} - {_institution}\n" +
                   $"Period: {_startYear} - {endYear}\n" +
                   $"Location: {_location}";
        }
    }
}
