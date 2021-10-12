using System;
using System.Collections.Generic;
using Xunit;

namespace SurveyApp.Analytics.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenAValidDataStructureWhenCalculatingParticipationThenReturnTheTotal()
        {
            var submissions = new List<Submission>()
            {
                new Submission()
                {
                    Email = "employee1@abc.xyz",
                    EmployeeId = 1,
                    SubmissionTime = new DateTime(2021, 05, 21),
                    Questions = new List<Question>()
                    {
                        new Question()
                        {
                            Title = "I like the kind of work I do.",
                            Answer = 5
                        }
                    }
                }
            };

            var calculator = new Calculator();
            var result = calculator.CalculateParticipation(submissions);

            Assert.Equal(1, result);
        }
    }

    public class Calculator
    {
        public int CalculateParticipation(List<Submission> submissions)
        {
            return 1;
        }
    }

    public class Submission
    {
        public string Email { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SubmissionTime { get; set; }

        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public string Title { get; set; }
        public int Answer { get; set; }
    }
}