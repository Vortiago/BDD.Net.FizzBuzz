namespace BDD.Net.FizzBuzz.Tests
{
    using System;
    using TechTalk.SpecFlow;
    using BDD.Net.FizzBuzz;
    using Xunit;

    [Binding]
    public class FizzBuzzValidator 
    {
        private readonly ScenarioContext _scenarioContext;
        private int input;
        private string output;

        public FizzBuzzValidator(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Given(@"a (.*) as input")]
        public void GivenANumberAsInput(int number)
        {
            this.input = number;
            //this.output = value;
        }

        [When(@"that number is divisible by three")]
        public void WhenThatNumberIsDivisibleByThree()
        {
        }

        [Then(@"the return (.*) should be fizz")]
        public void ThenTheApplicationShouldReturnFizz(string output)
        {
            var fizzBuzzHandler = new FizzBuzzHandler();
            Assert.Equal(output, fizzBuzzHandler.InputFeedback(this.input));
        }
    }
}