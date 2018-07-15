using System;

namespace Piwik.Tracker.Tests
{

    public class PiwikTrackerTests
    {
        private const string UA = "Firefox";
        private static readonly string PiwikBaseUrl = "http://ti15eb.asuscomm.com/piwik";
        private static readonly int SiteId = 7;

       
        public void GetCustomVariable_Test(Scopes variableScope, int? variableId, string variableName, string variableValue)
        {
            //Arrange
            var sut = new PiwikTracker(SiteId, PiwikBaseUrl);
            if (variableId != null)
            {
                sut.SetCustomVariable(variableId.Value, variableName, variableValue, variableScope);
            }
            //Act
            var actual = sut.GetCustomVariable(variableId ?? 99, variableScope);
        }
   
    }
}