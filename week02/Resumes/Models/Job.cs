
using System;

namespace Resumes.Models
{
    public class Job
    {
        private string _companyName;
        private string _jobTitle;
        private int _startYear;
        private int? _endYear;
        private string _employmentType;
        private string _jobDescription;
        private string _location;

        public Job(
            string companyName,
            string jobTitle,
            int startYear,
            int? endYear,
            string employmentType,
            string jobDescription,
            string location)
        {
            _companyName = companyName;
            _jobTitle = jobTitle;
            _startYear = startYear;
            _endYear = endYear;
            _employmentType = employmentType;
            _jobDescription = jobDescription;
            _location = location;
        }

        public void DisplayJob()
        {
            Console.WriteLine(ToText());
        }

        public string ToText()
        {
            string endYear = _endYear?.ToString() ?? "Present";

            return $"{_jobTitle} at {_companyName}\n" +
                   $"Period: {_startYear} - {endYear}\n" +
                   $"Type: {_employmentType}\n" +
                   $"Location: {_location}\n" +
                   $"Description: {_jobDescription}";
        }
    }
}
