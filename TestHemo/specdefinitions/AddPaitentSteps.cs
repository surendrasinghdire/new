using System;
using TechTalk.SpecFlow;

namespace TestHemo.specdefinitions
{
    [Binding]
    public class AddPaitentSteps
    {
        [Given(@"No patient is admitted")]
        public void GivenNoPatientIsAdmitted()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Given(@"Hemo Application is launched")]
        public void GivenHemoApplicationIsLaunched()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"user admits and starts a patient with Alex and John and (.*) and Test@(.*) and (.*)/(.*)")]
        public void WhenUserAdmitsAndStartsAPatientWithAlexAndJohnAndAndTestAnd(int p0, int p1, string p2, int p3)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"user verifies that the task of the philips Hemodynamic application is set to monitoring")]
        public void ThenUserVerifiesThatTheTaskOfThePhilipsHemodynamicApplicationIsSetToMonitoring()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"user verifies the default layout for the procedure is applied")]
        public void ThenUserVerifiesTheDefaultLayoutForTheProcedureIsApplied()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
