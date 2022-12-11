using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationInsights.Nodejsdemo.EmailService.Model
{
    public class TaskNotification
    {
        public string EmailAddress { get; set; }

        public string CurrentTasks { get; set; }

        public string CompletedTasks { get; set; }
    }
}
