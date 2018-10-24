using System;
using System.Collections.Generic;

namespace LambdaExp
{
    class Program
    {

        public class EmailSending
        {
            public int Id { get; set; }

            public string TaskName { get; set; }

            public String Description { get; set; }

            public string TargetDate { get; set; }

            public string SupportUserName { get; set; }

            public string ToEmail { get; set; }

            public string StatusName { get; set; }

            public string PriorityName { get; set; }

            public string PortalName { get; set; }

            public string ProjectName { get; set; }

            public int SId { get; set; }
        }
        static void Main(string[] args)
        {
            List<EmailSending> myList = new List<EmailSending>()
            {
                new EmailSending{Id=1, PortalName="netharland", ProjectName="project 2" , StatusName="Low", PriorityName="Mediu,", SupportUserName="Adnan", TargetDate="12/12/2012", TaskName="Task 1", ToEmail="abc@gmail.com" , SId = 1 },
                new EmailSending{Id=2, PortalName="uk", ProjectName="new Project" , StatusName="Pending", PriorityName="High", SupportUserName="Naveed", TargetDate="12/12/2019", TaskName="Task 2", ToEmail="naveed@gmail.com" , SId =2},
                new EmailSending{Id=3, PortalName="netharland", ProjectName="project 2" , StatusName="Low", PriorityName="Mediu,", SupportUserName="Adnan", TargetDate="12/12/2012", TaskName="Task 3", ToEmail="abc@gmail.com" , SId = 1 },
            };

            var abc = myList.Find(x => x.SId == 1);

            foreach (var item in myList)
            {
                Console.WriteLine($"{item.Id} {item.TaskName}");
            }

        }
    }
}
