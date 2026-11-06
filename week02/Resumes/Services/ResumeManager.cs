using System;
using System.IO;
using Resumes.Models;

namespace Resumes.Services
{
    public class ResumeManager
    {
        public void SaveResume(Resume resume, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Resume saved successfully.");
                writer.WriteLine("Use the console display to review your resume.");
            }

            Console.WriteLine("Resume saved!");
        }
    }
}