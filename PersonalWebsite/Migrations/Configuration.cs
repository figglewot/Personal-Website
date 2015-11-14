using PersonalWebsite.Models;
using PersonalWebsite.Models.Blog;
using PersonalWebsite.Models.Resume;

namespace PersonalWebsite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<awrightBlogDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PersonalWebsite.Models.awrightBlogDb";
        }

        protected override void Seed(awrightBlogDb context)
        {
            context.Certifications.AddOrUpdate(r => r.Title,
                new Certifications()
                {
                    Title = "<a href='http://www.pluralsight.com/courses/mvc4-building'>Building Applications with ASP.NET MVC 4</a>",
                    Grantor = "Pluralsight"
                },
                new Certifications()
                {
                    Title = "<a href='http://www.pluralsight.com/courses/object-oriented-programming-fundamentals-csharp'>Object-Oriented Programming Fundamentals in C#</a>",
                    Grantor = "Pluralsight"
                },
                new Certifications()
                {
                    Title = "<a href='http://www.pluralsight.com/courses/defensive-coding-csharp'>Defensive Coding in C#</a>",
                    Grantor = "Pluralsight"
                },
                new Certifications()
                {
                    Title = "<a href='http://www.pluralsight.com/courses/csharp-interfaces'>C# Interfaces</a>",
                    Grantor = "Pluralsight"
                },
                new Certifications()
                {
                    Title = "<a href='http://www.pluralsight.com/courses/csharp-generics'>C# Generics</a>",
                    Grantor = "Pluralsight"
                },
                new Certifications()
                {
                    Title = "<a href='http://www.pluralsight.com/courses/csharp-fundamentals-csharp5'>C# Fundamentals with C# 5.0</a>",
                    Grantor = "Pluralsight"
                }
                );
            context.Experience.AddOrUpdate(r => r.Company,
                new Experience()
                {
                    Company = "<h4>Paylocity</h4>",
                    JobTitle = "<h5>Software Development Engineer in Test</h5>",
                    DatesWorked = "<h6>March 2015 - Present</h6>",
                    ExperienceDetail = "<article><p>" +
                        "Architect and develop keyword driven data model and utilize C#, Selenium, Ninject and Visual Studio to develop software for automated testing " + 
                        "tailored to specific SCRUM teams needs. Create and execute implementation plan for building and executing " + 
                        "automated testing regression. Perform building and execution of test cases according to User Story specifications. " + 
                        "Utilize C#, MVC, and SQL to maintain, improve, and enhance existing enterprise software by performing " + 
                        "bugfixes and refactoring pain points. Cut down manual process time by developing software around " +
                        "automating repetitive tasks." +
                    "</p></article>"
                },
                new Experience()
                {
                    Company = "<h4>Paychex, Inc</h4>",
                    JobTitle = "<h5>Software Development Engineer in Test II, Automation</h5>",
                    DatesWorked = "<h6>May 2012 - March 2015</h6>",
                    ExperienceDetail = "<article><p>" +
                        "Utilized C#, Selenium, and Visual Studio to develop a stand-alone automated testing framework for enterprise " +
                        "wide use. Utilized VBScript and HP QuickTest Professional / Unified Functional Testing to refactor, clean, and " +
                        "optimize existing enterprise automated testing software. Co-ordinated with the Enterprise Information Security Teams " +
                        "to create and maintain security policies to allow the use of annonymous Windows users on 55 + VMWare machines " +
                        "to execute enterprise wide automation testing. Led enterprise wide efforts in providing QA with education on " +
                        "developing keyword driven automation and how to define element paths with values such as ID, Name, and XPath. " +
                    "</p></article>"
                },
                new Experience()
                {
                    Company = "<h4>Paychex, Inc</h4>",
                    JobTitle = "<h5>Information Security Administrator</h5>",
                    DatesWorked = "<h6>January 2012 - May 2012</h6>",
                    ExperienceDetail = "<article><p>" +
                        "Utilized PuTTy and Toad to provide all electronic identity for employees on UNIX Servers and Oracle Databases " +
                        "based on formal business unit requests. Managed Coporate compliance with Sarbanes-Oxley business auditing " +
                        "standards by consistently monitoring user accounts through the corporate separation process. Managed " +
                        "all remote VPN access by creating, modifying, and removing access via ENTRUST security infrastructure. Acted " +
                        "as a primary security department contact point for business continuity planning events to ensure the prompt " +
                        "restoration of critical business functions during unforeseen outages as well as the prompt removal upon " +
                        "completion of the event. Monitored daily privileged access logs and requests looking for malicious and/or " +
                        "inappropriate activity. Performed testing and development of automated tools to cut down on manual user account " +
                        "provisioning tasks." +
                    "</p></article>"
                },
                new Experience()
                {
                    Company = "<h4>SUNY College of Technology at Alfred</h4>",
                    JobTitle = "<h5>Resident Assistant</h5>",
                    DatesWorked = "<h6>August 2011 - January 2012</h6>",
                    ExperienceDetail = "<article><p>" +
                        "Led a floor of 21 residents by being a positive role model and stong community builder. Hosted programs in my building " +
                        "that provided certain levels of educational, social, and cultural experience.Brought different cultural communities " +
                        "together by providing a ground of common interest and introducing cultural traditions to diverse groups as a whole. " +
                        "Hosted campus wide programs to promote interest in diversity." +
                    "</p></article>"
                },
                new Experience()
                {
                    Company = "<h4>SUNY College of Technology at Alfred</h4>",
                    JobTitle = "<h5>Network Technician</h5>",
                    DatesWorked = "<h6>May 2011 - January 2012</h6>",
                    ExperienceDetail = "<article><p>" +
                        "Utilized Cisco and Aruba technologies to maintain wired and wireless connectivity to each dorm, academic, and other functional " +
                        "buildings on campus.Conducted toning, tracing, testing, Cisco switch configuration and installation, and Aruba access point configuration " +
                        "and installation. Monitored Aruba Controller for rogue activity to reduce risk of malicious activity. Provided support and troubleshooting " +
                        "to the telephone network campus wide utilizing both VoIP and analog technologies." +
                    "</p></article>"
                }
                );
            context.Skills.AddOrUpdate(r => r.Skill,
                new Skills()
                {
                    Skill = "C#"
                },
                new Skills()
                {
                    Skill = "VB"
                },
                new Skills()
                {
                    Skill = "MVC"
                },
                new Skills()
                {
                    Skill = "Razor"
                },
                new Skills()
                {
                    Skill = "ASP.NET"
                },
                new Skills()
                {
                    Skill = "SQL"
                },
                new Skills()
                {
                    Skill = "Selenium"
                },
                new Skills()
                {
                    Skill = "Robot Framework"
                },
                new Skills()
                {
                    Skill = "JavaScript"
                },
                new Skills()
                {
                    Skill = "VBScript"
                },
                new Skills()
                {
                    Skill = "jQuery"
                },
                new Skills()
                {
                    Skill = "XML"
                },
                new Skills()
                {
                    Skill = "XPath"
                },
                new Skills()
                {
                    Skill = "WinForms"
                },
                new Skills()
                {
                    Skill = "Git"
                },
                new Skills()
                {
                    Skill = "Stash"
                },
                new Skills()
                {
                    Skill = "SourceTree"
                },
                new Skills()
                {
                    Skill = "Perfecto Mobile"
                },
                new Skills()
                {
                    Skill = "Visual Studio"
                }
                );
            context.Interests.AddOrUpdate(r => r.Interest,
            new Interests()
            {
                Interest = "Auto Mechanics"
            },
            new Interests()
            {
                Interest = "Auto Restoration"
            },
            new Interests()
            {
                Interest = "Muscle Cars"
            },
            new Interests()
            {
                Interest = "Ham Radio - KC2RQI"
            },
            new Interests()
            {
                Interest = "Dark Tea"
            },
            new Interests()
            {
                Interest = "Red Tea"
            },
            new Interests()
            {
                Interest = "Belgian Ales"
            },
            new Interests()
            {
                Interest = "Highland Scotch"
            },
            new Interests()
            {
                Interest = "Food :)"
            }
            );
        }
    }
}
