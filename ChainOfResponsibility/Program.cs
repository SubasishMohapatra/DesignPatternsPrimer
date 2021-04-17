using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start interview");
            var interviewer1 = new Interviewer1();
            var interviewer2 = new Interviewer2();
            var interviewer3 = new Interviewer3();
            interviewer1.SetNext(interviewer2).SetNext(interviewer3);
            interviewer1.TakeInterview();
            Console.WriteLine("Interview over");
        }
    }

    interface IInterviewer
    {
        IInterviewer SetNext(IInterviewer interviewer);
        void TakeInterview();
    }

    class Interviewer1 : BaseInterview,IInterviewer
    {
        public Interviewer1():base("Round1")
        {

        }       
    }
    class Interviewer2 : BaseInterview, IInterviewer
    {
        public Interviewer2() : base("Round2")
        {

        }
    }
    class Interviewer3 : BaseInterview, IInterviewer
    {
        public Interviewer3() : base("Round3")
        {

        }
    }
}
