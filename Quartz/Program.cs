using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quartz
{
    class Program
    {
        static void Main(string[] args)
        {
            // construct a scheduler factory
            ISchedulerFactory schedFact = new StdSchedulerFactory();

            // get a scheduler
            IScheduler sched = schedFact.GetScheduler();
            sched.Start();

            // define the job and tie it to our HelloJob class
            IJobDetail job = JobBuilder.Create<HelloJob>()
                .WithIdentity("myJob", "group1")
                .Build();

            // Trigger the job to run now, and then every 40 seconds
            ITrigger trigger = TriggerBuilder.Create()
              .WithIdentity("myTrigger", "group1")
              .StartNow()
              .WithSimpleSchedule(x => x
                  .WithIntervalInSeconds(5)
                  .RepeatForever())
              .Build();

            sched.ScheduleJob(job, trigger);

            IJobDetail job2 = JobBuilder.Create<HelloJob2>()
                .WithIdentity("myJob2", "group2")
                .Build();

            // Trigger the job to run now, and then every 40 seconds
            ITrigger trigger2 = TriggerBuilder.Create()
              .WithIdentity("myTrigger2", "group2")
              .StartNow()
              .WithSimpleSchedule(x => x
                  .WithIntervalInSeconds(10)
                  .RepeatForever())
              .Build();

            //sched.ScheduleJob(job2, trigger2);
        }
    }

    public class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //Console.Clear();
            Console.WriteLine("\nNowe zadanie\n");

            Console.WriteLine("1.1\t" + DateTime.Now.ToLongTimeString());
            Console.WriteLine("(+2s)");
            Thread.Sleep(2000);
            Console.WriteLine("1.2\t" + DateTime.Now.ToLongTimeString());
        }
    }

    public class HelloJob2 : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("2\t" + DateTime.Now.ToLongTimeString());
        }
    }
}
