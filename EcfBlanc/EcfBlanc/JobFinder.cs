using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcfBlanc
{
    public class JobFinder
    {
        private System.Collections.Generic.List<JobSeeker> jobSeekers;

        public List<JobSeeker> JobSeekers
        {
            get { return jobSeekers; }
            private set { jobSeekers = value; }
        }

        public JobFinder()
        {
            jobSeekers = new List<JobSeeker>();
        }

        public void AddJobSeeker(JobSeeker _jobSeekerToAdd)
        {
            jobSeekers.Add(_jobSeekerToAdd);
        }

        public static int CalculateEmployability(JobSeeker jobSeeker)
        {

            switch ((int)jobSeeker.TrainingLevel)
            {
                case 0:
                    return 30;
                case 1:
                    return 40;
                case 2:
                    return 50;
                case 3:
                    return 60;
                case 4:
                    return 70;
                case 5:
                    return 80;
                case 6:
                    return 90;
                case 7:
                    return 100;

                default:
                    return 0;
            }
        }
    }
}