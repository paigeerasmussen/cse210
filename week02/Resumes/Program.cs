using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2006";
        job1._endYear = "2019";

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = "2016";
        job2._endYear = "2023";

        Resume myResume = new Resume();
        myResume._name = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}