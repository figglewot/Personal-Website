using PersonalWebsite.Models;

namespace PersonalWebsite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PersonalWebsite.Models.awrightBlogDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PersonalWebsite.Models.awrightBlogDb";
        }

        protected override void Seed(PersonalWebsite.Models.awrightBlogDb context)
        {
            context.BlogPosts.AddOrUpdate(r => r.Title,
                new BlogPost {Id = 1,
                    Title = "Hello World And A Cup of Tea",
                    Date = "<h5>Aug 23 2015</h5>",
                    Body = "<p>Hello world! I'd like to welcome you to my re-designed blog. This is my first attempt at using angularJS as the driving element to bind data to html elements.</p><p>Most likely, my usage will evolve overtime as I learn through refactoring, but this is pretty exciting nonetheless.</p><p>I will be using this space to share my views on current things that interest me, problems that I have experienced and overcome, and the sort.</ p ><p> My goal is to publish atleast one article on here weekly to start and overtime as I become more assimilated with writing about things I'll hopefully get on to putting out more material.</p>",
                    PostUrl = "hello_world_and_a_cup_of_tea"
                    },
                new BlogPost
                {
                    Id = 2,
                    Title = "Blog Work In Progress",
                    Date = "<h5>Sep 19 2015</h5>",
                    Body = "<p>I realize that I have a ton of realestate that is unaccounted for on my pages.</p><p> But I really like the flow of the basic scaffolding for now.</p><p>//TODO: Add more content :)</p>",
                    PostUrl = "blog_work_in_progress"
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "Why Mentorship is a Win-Win Scenario",
                    Date = "<h5>Sep 20 2015</h5>",
                    Body = "<p>" +
                        "A mentorship is one of the most valuable things an individual could ever hope to find in a constantly morphing environment where best practices and industry standards " +
                        "are not yet fluent in your domain knowledge." +
                    "</p>" +
                    "<p>" +
                        "Take the case of Software Development. The thing I love most about being in this field is that there is no right or wrong way to achieve a task, and there " +
                        "are countless WAYS of achieving that task. But there are more better and less bad ways, which are drawn out more or less by the best practices and industry standards " +
                        "put together by a community of really smart people." +
                    "</p>" +
                    "<p>" +
                        "Where the difficulty lies however, is in learning and applying those standards. If a person is fresh out of school and entering into a junior position, or if a person " +
                        "is a non-traditional engineer learning to be awesome in their spare time, those standards may not be known or obvious. A good mentor can help you overcome these " +
                        "difficulties." +
                    "</p>" +
                    "<p>" +
                        "Mentorship does not just apply to learning the best practices and industry standards. A good mentor can also provide you with a push in the right direction as far " +
                        "as learning tracks are concerned, review your work, and answer questions as well as provide rationales to help you understand why x equals what it does." +
                    "</p>" +
                    "<p>Being a mentor is not for everyone, but being a mentor is also a reward in it's own. You might ask, why?</p>" +
                    "<p>" +
                        "As a mentor, you need to work harder on top of your already busy job to help someone who may be far less skilled than you out. Here are some things to keep in mind. " +
                        "You will be answering a lot of foundational level questions and doing so in a way that a person with basic understandings of things can understand, this reinforces " +
                        "your knowledge base and allows you to look at things from another perspective. You will be performing detailed reviews on their work and explaining how they could " +
                        "have done things differently and why doing it differently is better, which gives you the opportunity to rethink why you do things in your way and look at what a fresh " +
                        "mind is thinking and why they are thinking that way, good or not. A sense of accomplishment. When your mentoree does something epic and starts to understand on the levels " +
                        "that you are explaining to them, it is a sense of accomplishment, and, subjectively, a general awesome feeling." +
                    "</p>" +
                    "<p>" +
                        "As a mentoree, this is awesome. I think personality type really determines the sort of mentoree you are. Being a mentoree does not mean that you are free " +
                        "from responsibilities, because you are not. Being a mentoree does not mean you are letting someone else give you the answer or do your work for you. As a mentoree, " +
                        "you should get only the necessary instruction to fit your learning type and struggle to learn and apply what your mentor has given you, and ask questions appropriate " +
                        "to the problem that you are having. For some, a reference book and online tutorials are not enough. If this is the case, a good mentoree will still have these resources available to them, " +
                        "but they will use them as supplemental learning material to what their mentor has to offer them. If this is not the case, a good mentoree will use these resources " +
                        "and apply knowledge learned from there and check concepts and understandings and perform reviews with their mentor." +
                    "</p>" +
                    "<p>" +
                        "Utilized properly and mutually, a good mentorship can bolster both parties careers and yield dividends. Most Software Organizations today love mentor programs and encourage it. " +
                        "They might also offer incentives for individuals to offer themselves up as mentors and advise new employees to seek mentorship opportunities." +
                    "</p>" +
                    "<p>Author's Note:</p>" +
                    "<p>" +
                        "Over the past few months, I have been aggressively learning new and awesome skills to move my career forward to places I had in the past thought " +
                        "unreachable and impossible. I owe a great deal of this credit to a fine gentleman and mentor, Mr. Spike Higgins. It is because of his guidance and inspiration that I have been " +
                        "able to so quickly work to transition from what I thought was acceptable to realize what I find passionate and enjoyable and that I am actually pretty good at. " +
                        "While I still have a long way to go, a great mentor has provided me with a strong foundation and kickstarted that process. Even if he thinks he didn't do much xD" +
                    "</p>",
                    PostUrl = "why_mentorship_is_a_win_win_scenario"
                },
                new BlogPost
                {
                    Id = 4,
                    Title = "Developer Biases are Toxic",
                    Date = "<h5>Sep 25 2015</h5>",
                    Body = "<p>" +
                        "For some time, there has been a segregation of sorts around the different types of programming languages. The biggest known division in the community is that of " +
                        "the battle between Java and .NET. It is a true shame that when a .NET developer enters into a legimiate conversation with a Java developer to exchange ideas and converse " +
                        "and is frowned at and shunned off. Is being a developer that uses Microsoft tools and technologies that much of a poison to the community? If so, why? I " +
                        "seriously invite the reader to explain this. Individuals on various Q&A sites such as StackOverflow seem happy to reach out past their Stack to answer questions and " +
                        "participate in conversation. However, when faced in the real world, the indifference towards one another is real. " +
                    "</p>" +
                    "<b>The Biases Go Both Ways</b>" +
                    "<p>" +
                        "Before getting too far into it, I would like to say Microsoft devs vs Java/Java-'esque' devs both have their petty indifferences towards each other. I am not saying that " +
                        "it is a one sided battle and calling out the Non-Microsoft developers as being jerks. I'm also not saying that everyone does this, but I have noticed it enough in different " +
                        "places to decide to write this blog entry about it." +
                    "</p>" +
                    "<b>This Hurts the Development Community</b>" +
                    "<p>" +
                        "You may be reading this and say, I develop in X language and why should I care what someone who develops in Y language thinks? The answer is you should, and if you disagree, " +
                        "well, you should reconsider. Here are some reasons why:" +
                    "</p>" +
                    "<b>We All Have Something to Offer</b>" +
                    "<p>" +
                        "Every developer in the community has something to offer. And I have a pretty good example of that. Recently, I attended a conference where I could safely count the number " +
                        "of .NET developers in attendance with my hands. I overheard a gentleman talking about an issue he was having wishing he could include something in his Java codebase to " +
                        "fail builds if inputs were not properly sanitized to prevent SQLi/XSS. Putting the entire concept of Entity Framework we have available to us in .NET aside, " +
                        "I bravely interjected and introducted the concept of code contracts. He paused, looked at me, and asked, Code Contracts? I went on to explain what code contracts " +
                        "were and if Java had an implementation or library for code contracts, then he could easily write compiler level sanitization rules to fail builds if those criteria were not met. " +
                        "Said individual was thrilled and respect level increased substaintially. I feel there are many instances where Java and .NET developers alike could share ideas, concepts, and solutions that we could cross " +
                        "implement if we overcome these differences." +
                    "</p>" +
                    "<b>Going Beyond Your Stack is Good</b>" +
                    "<p>" +
                        "This section keys off my last bit. You learn and see how other stacks achieve things. There is absolutely nothing wrong with knowing more than one way to do something, especially " +
                        "if you are able to find a concept that will save you time and money and will achieve your task in a cleaner and more efficient way. You also learn a lot more and are able " +
                        "to reach out to a much wider audience. Going outside your Stack is in the same lines as being a well diversified and cultured individual. There is an endless amount of value " +
                        "in going outside your bounds and learning more than one way. " +
                    "</p>" +
                    "<p>" +
                        "Recently, Microsoft has announced its goals to move towards an open source platform. Already, you can get <a href='https://code.visualstudio.com/'>Microsoft Code</a>, a light-weight " +
                        ".NET IDE that works cross platform to develop .NET code free of charge. This will light the beacon towards a great future for .NET developers. In time, I hope that this " +
                        "will strengthen the relationships that we as developers have together and open new doors to success for us all. This is very exciting, and going outisde of our Stacks can help " +
                        "us to bring features and functionalities from one Stack to another." +
                    "</p>",
                    PostUrl = "developer_biases_are_toxic"
                },
                new BlogPost
                {
                    Id = 5,
                    Title = "Automation is a Good Thing",
                    Date = "<h5>Oct 2 2015</h5>",
                    Body = "<p>" +
                        "In the world of software and computer science, we treat automation like a holy grail. Everyone wants to achieve it, but we always struggle with the " +
                        "business to implement it. I'd like to use this post to talk a bit about the Paradox of Automation, justifications for automation, and how it can help " +
                        "your business in an array of ways." +
                    "</p>" +
                    "<b>What is the Paradox of Automation?</b>" +
                    "<p>" +
                        "The Paradox of Automation states that while reducing human time to perform a task, human interaction with the Automata becomes crucial. We will spend " +
                        "less time doing the task but spend more time developing, improving, and repairing the automata. This is a good thing. We want to spend less time doing " +
                        "the same repetative tasks over and over again and spend more of our time creating ways to rid ourselves of the tedious tasks we perform without much thought." +
                    "</p>" +
                    "<b>The Business Cost</b>" +
                    "<p>" +
                        "Everytime I have brought up the question of building automation in to our solutions the questions have always been something like:" +
                    "</p>" +
                    "<p>" +
                        "<ol>" +
                            "<li>What is this going to cost me?</li>" +
                            "<li>How much time will you need to spend on this?</li>" +
                            "<li>What is the value add?</li>" +
                            "<li>When can I see results?</li>" +
                        "</ol>" +
                    "</p>" +
                    "<p>" +
                        "These questions are pretty fair, and they are subjective to the skillsets of your team and sort of automata your team wants to implement. In the case of the " +
                        "automation consulting I provide to software testing teams, the answers to these questions are a bit more subjective to the sort of software they are testing." +
                    "</p>" +
                    "<p>" +
                        "For example, the cost would be as much as the vendor solutions the team choses to use, with many free open-source tools available such as Selenium. " +
                        "The amount of time needed is relative, and a good way to guage this is to start by automating a small task. That small task can be anything as broad as something " +
                        "that your team does often enough to be tired of doing, or something as specific as a build acceptance test that you want to automate. Once that task is complete, " +
                        "now you have a few things at your disposal to bring to management. " +
                    "</p>" +
                    "<p>" +
                        "You have metrics. These are pieces of data that managers and business-y type people use to visualize time spent and time saved on tasks." +
                    "</p>" +
                    "<p>" +
                        "You have a working example. With that, you can now demonstrate at a high level what you can achieve through automation. What I have found is that " +
                        "managers never fully realize what they are dealing with until they see it work, and once they see it work they accept how awesome it is and want more. You have " +
                        "a foundation. Once you get your feet wet with building the first working cog, the rest will fall into place faster and nicer." +
                    "</p>" +
                    "<b>Why does Human Interaction Become More Crucial?</b>" +
                    "<p>" +
                        "Automation is a very cool paradox. Take the instance of automobiles for example. Automobiles have become a very important factor in today's world. " +
                        "We use them in our lives daily to get from home to where ever we need to go and back. But they break, they wear out, they fall short of many conveniences. " +
                        "Because of that, we need repair shops and constant innovations engineering new designs. As Humans, we constantly want more and we constantly want better, " +
                        "it is just our nature." +
                    "</p>" +
                    "<p>" +
                        "The same is the case for automation in the software world. For each Automata we build, there will always be ways to make it better and there will always " +
                        "be the need to fix it. This sounds a bit counter-productive, spending so much time and investing more and more into the thing that was supposed to save " +
                        "us time from the tasks we were doing, why not just stick to manually doing those tasks? " +
                    "</p>" +
                    "<p>" +
                        "We will always have more and more work to do. By developing automata to take on the majority of our redundant work loads, we can dedicate a smaller pool " +
                        "of resources to working with the automata and focus on new work that hasn't yet been included into it. This saves us from having to add more and more " +
                        "physical bodies to our software teams. And, subjectively, just make us happier people in general. " +
                    "</p>" +
                    "<b>What are the up-front costs?</b>" +
                    "<p>" +
                        "If this is your team's first time in dealing with automation in any fashion, it is going to seem expensive. This is because, like any other product or project, " +
                        "there is always an investment required before you can see your return. It will require you to spend some time on research and development to get off the ground " +
                        "into kinetic motion. The return on investment can be quickly seen, however. Some advice in the realm of software testing is to start early. If you have a project " +
                        "that it is in its infacy, it is very important that you build automation in to your SDLC and work with your fellow developers to ensure it is a priority, as it will " +
                        "save you a vast amount of time and money later on." +
                    "</p>" +
                    "<p>" +
                        "When talking about up-front costs of automation in any instance, treat it as merely a shadowed veil with the big treasure chest containing the dungeon item on the " +
                        "other side." +
                    "</p>" +
                    "<b>This All Sounds Risky, is it Really for Me?</b>" +
                    "<p>" +
                        "I think the biggest factor that shuts out automation is fear of failure either due to previous attempts or the unknown. I have seen fear become a blocker countless " +
                        "times. If your team has given an automated solution for your manual tasks a try and the past, now is a great time to reflect on that failure and figure out what " +
                        "caused it to fail and analyze the why. If your team has not given an automated solution for your manual tasks a try yet, give it a go. Take initial steps to analyze " +
                        "what you want to automate, what technology you want to use to do the automation. Put together some small working proof of concepts. It is ok to involve one or two " +
                        "resources initially, but DO involve more overtime and DO educate the team on what it is, how to work with it, how to extend it, how to understand it. This is crucial " +
                    "</p>" +
                    "<b>Automate, Automate, Automate</b>" +
                    "<p>" +
                        "In the past, present, and future, automation is an essential ally to us all. It is imperative that teams develop new strategies, revisit old ones, and constantly " +
                        "innovate automation." +
                    "</p>" +
                    "<p>" +
                        "Also, Open Source all the things :) - Shameless plug from a 'dirty' .NET developer." +
                    "</p>",
                    PostUrl = "automation_is_a_good_thing"
                }
                );
        }
    }
}
