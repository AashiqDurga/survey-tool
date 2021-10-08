using System;
using System.IO;
using Xunit;

namespace SurveyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenValidInputFileWhenPassingTheParticipationCommandThenReturnResults()
        {
            var inputFile = File.ReadAllLines("example-data/survey.csv");
            var actual = "";
            
            var expected = @"Participation

            Participants: 6
            Submitted: 5 (83.3%)";
            Assert.Equal(expected, actual);
        }
    }
}