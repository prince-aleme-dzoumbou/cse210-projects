
using System;
using System.Collections.Generic;
using System.IO;

namespace Resumes.Models
{
    public class Resume
    {
        private string _name;
        private List<Job> _jobs;
        private List<Education> _educations;
        private List<Skill> _skills;

        public Resume(string name)
        {
            _name = name;
            _jobs = new List<Job>();
            _educations = new List<Education>();
            _skills = new List<Skill>();
        }

        public void AddJob(Job job)
        {
            _jobs.Add(job);
        }

        public void AddEducation(Education education)
        {
            _educations.Add(education);
        }

        public void AddSkill(Skill skill)
        {
            _skills.Add(skill);
        }

        public string GetResumeText()
        {
            using (StringWriter writer = new StringWriter())
            {
                writer.WriteLine("========== MY RESUME ==========");
                writer.WriteLine($"Name: {_name}");

                writer.WriteLine("\n--- PROFESSIONAL EXPERIENCE ---");

                foreach (Job job in _jobs)
                {
                    writer.WriteLine(job.ToText());
                    writer.WriteLine();
                }

                writer.WriteLine("--- EDUCATION ---");

                foreach (Education education in _educations)
                {
                    writer.WriteLine(education.ToText());
                    writer.WriteLine();
                }

                writer.WriteLine("--- SKILLS ---");

                foreach (Skill skill in _skills)
                {
                    writer.WriteLine(skill.ToText());
                }

                writer.WriteLine("===============================");

                return writer.ToString();
            }
        }

        public void DisplayResume()
        {
            Console.WriteLine(GetResumeText());
        }
    }
}
