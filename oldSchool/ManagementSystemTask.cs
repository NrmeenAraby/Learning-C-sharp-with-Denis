using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal interface ITask<T>
    {
        public T perform();
    }

    internal class EmailTask : ITask<string>
    {
        public string Recipient { get; set; }
        public string msg { get; set; }

        public string perform()
        {
            return $"This {msg}  from: {Recipient}";
        }
    }
    internal class ReportTask : ITask <string>{
        public string ReportName { get; set; }

        public string perform()
        {
            return $"The {ReportName} done.";
        }
    }
    internal class TaskProcessor<TTask, TResult> where TTask :ITask<TResult>
    {
        TTask task;
        public TaskProcessor(TTask task)
        {
            this.task = task;
        }
        public TResult Execute()
        {
            return task.perform();
        }
    }
}