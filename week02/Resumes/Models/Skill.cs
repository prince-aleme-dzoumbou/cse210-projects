

using System;

namespace Resumes.Models
{
    public class Skill
    {
        private string _name;
        private string _level;

        public Skill(string name, string level)
        {
            _name = name;
            _level = level;
        }

        public void DisplaySkill()
        {
            Console.WriteLine(ToText());
        }

        public string ToText()
        {
            return $"{_name} - {_level}";
        }
    }
}