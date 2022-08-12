using CalculatorLib;
using System;
using TechTalk.SpecFlow;

namespace BDD_Calculator
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private Calculator calculator;
        private int result;
        private Exception _actualException;
        private List<int> _myList = new List<int>();

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calculator = new Calculator();
        }

        [Given(@"I enter (.*) and (.*) in the calculator")]
        public void GivenIEnterAndInTheCalculator(int x, int y)
        {
            calculator.Num1 = x;
            calculator.Num2 = y;
        }

        [Given(@"I enter the numbers below to a list")]
        public void GivenIEnterTheNumbersBelowToAList(Table table)
        {
            foreach (var row in table.Rows)
            {
                _myList.Add(int.Parse(row[0].Trim()));
            }
        }

        [When(@"I iterate through the list to add all the even numbers")]
        public void WhenIIterateThroughTheListToAddAllTheEvenNumbers()
        {
            result = calculator.SumDivisibleBy2();
        }


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [When(@"I press Subtract")]
        public void WhenIPressSubtract()
        {
            result = calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            try
            {
                result = calculator.Divide();
            }
            catch (Exception ex)
            {
                _actualException = ex;
            }
        }

        [Then(@"a DivideByZero Exception should be thrown")]
        public void ThenADivideByZeroExceptionShouldBeThrown()
        {
            Assert.That(_actualException, Is.TypeOf<DivideByZeroException>());
        }

        [Then(@"the exception should have the message ""([^""]*)""")]
        public void ThenTheExceptionShouldHaveTheMessage(string p0)
        {
            Assert.That(_actualException.Message, Is.EqualTo(p0));
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
