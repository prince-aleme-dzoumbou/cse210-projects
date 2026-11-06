using System;
using Resumes.Models;
using Resumes.Services;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume("Prince Aleme Dzoumbou");

        
        Job job1 = new Job(
            "Company MTN Congo",
            "Junior Frontend Developer",
            2025,
            null,
            "Full-time",
            "Developed responsive web interfaces.",
            "Brazzaville, Congo"
        );

        Job job2 = new Job(
            "Company BiviTech",
            "IT Support Assistant",
            2024,
            2025,
            "Part-time",
            "Provided technical support to users.",
            "Brazzaville, Congo"
        );

    
        resume.AddJob(job1);
        resume.AddJob(job2);

   
        Education education = new Education(
            "BYU-Idaho / BYU-Pathway Worldwide",
            "Software Development",
            2026,
            null,
            "Online"
        );

        resume.AddEducation(education);

       
        Skill skill1 = new Skill("HTML", "Intermediate");
        Skill skill2 = new Skill("CSS", "Intermediate");
        Skill skill3 = new Skill("C#", "Beginner");

        resume.AddSkill(skill1);
        resume.AddSkill(skill2);
        resume.AddSkill(skill3);

       
        resume.DisplayResume();

        
        ResumeManager manager = new ResumeManager();
        manager.SaveResume(resume, "my-resume.txt");
    }
}