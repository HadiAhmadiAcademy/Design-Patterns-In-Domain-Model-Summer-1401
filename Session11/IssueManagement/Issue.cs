using System;

namespace IssueManagement
{
    public class Issue
    {
        //...
        //...
        //...
        //...
        public DateTime DueDate { get; private set; }
        public IssueState State { get; private set; }
        public long PenaltyScore { get; private set; }
        public void Resolve()
        {
            this.PenaltyScore = this.State.CalculatePenalty(this);
            //......
        }
    }

    public abstract class IssueState
    {
        public abstract long CalculatePenalty(Issue issue);
    }

    public class NormalIssue : IssueState
    {
        public override long CalculatePenalty(Issue issue)
        {
            //if (issue.DueDate > ...)
            return 10;
        }
    }

    public class MajorIssue : IssueState
    {
        public override long CalculatePenalty(Issue issue)
        {
            //if (issue.DueDate > ...)
            return 15;
        }
    }

    public class CriticalIssue : IssueState
    {
        public override long CalculatePenalty(Issue issue)
        {
            //if (issue.DueDate > ...)
            return 30;
        }
    }
}