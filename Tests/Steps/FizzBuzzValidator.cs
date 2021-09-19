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

        public FizzBuzzValidator(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Given(@"a (.*) as input")]
        public void GivenANumberAsInput(int number)
        {
            this.input = number;
        }

        [When(@"that number is divisible by (.*)")]
        public void WhenThatNumberIsDivisibleBy(string divisibleBy)
        {
        }

        [When(@"that number is not part of the other rules")]
        public void WhenThatNumberIsNotPartOfTheOtherRules()
        {
        }

        [Then(@"the return should be (.*)")]
        public void ThenTheApplicationShouldReturnFizz(string output)
        {
            var fizzBuzzHandler = new FizzBuzzHandler();
            Assert.Equal(output, fizzBuzzHandler.InputFeedback(this.input));
        }
    }
}