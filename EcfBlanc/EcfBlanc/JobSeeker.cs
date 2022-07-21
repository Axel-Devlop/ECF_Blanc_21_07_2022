using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcfBlanc
{
    public class JobSeeker
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public readonly int inscriptionDate;
        public trainingLevel TrainingLevel { get; private set; }
        public string NameOfLastDiploma { get; private set; }
        public int DateOfLastDiploma { get; private set; }
        public readonly int id;
        public JobFinder JobFinderLinkedTo { get; private set; }

        public JobSeeker(string _firstname, string _lastname, int _inscriptionDate, trainingLevel _trainingLevel, string _nameOfLastDiploma, int _dateOfLastDiploma, JobFinder _jobFinderLinkedTo)
        {
            FirstName = _firstname;
            LastName = _lastname;
            inscriptionDate = _inscriptionDate;
            TrainingLevel = _trainingLevel;
            NameOfLastDiploma = _nameOfLastDiploma;
            DateOfLastDiploma = _dateOfLastDiploma;
            JobFinderLinkedTo = _jobFinderLinkedTo;
            JobFinderLinkedTo.AddJobSeeker(this);
            id = JobFinderLinkedTo.JobSeekers.Count;
        }



    }
}