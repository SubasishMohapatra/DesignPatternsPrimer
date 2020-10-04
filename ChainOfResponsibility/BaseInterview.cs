using System;
using System.Threading;

namespace ChainOfResponsibility
{
    internal class BaseInterview
    {
        string _interviewRound;
        public BaseInterview(string interviewRound)
        {
            _interviewRound = interviewRound;
        }
        public IInterview _nextInterviewer;
        public bool clearedCandidate = false;
        public IInterview SetNext(IInterview nextInterviewer)
        {
            _nextInterviewer = nextInterviewer;
            return _nextInterviewer;
        }

        public void TakeInterview()
        {
            Console.WriteLine("Waiting for feedback: Enter Y for Yes else any other key for No");
            var result = Console.ReadKey();
            Console.WriteLine();
            if (result.Key == ConsoleKey.Y)
            {
                Console.WriteLine($"Candidate cleared {_interviewRound}");
                if (_nextInterviewer != null)
                {
                    Console.WriteLine($"Next round started");
                    _nextInterviewer.TakeInterview();
                }
                else
                {
                    Console.WriteLine($"Candidate selected");
                }
            }
            else
                Console.WriteLine($"Candidate didn't clear {_interviewRound}");
        }
    }
}