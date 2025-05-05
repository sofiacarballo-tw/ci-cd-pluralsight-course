using ci_cd_pluralsight_course;

namespace ci_cd_pluralsight_course_test;

public class CalculatorShould
{
    [Test]
    public void AddTwoNumbers()
    {
        var calculator = new Calculator();
        const int firstNumber = 2;
        const int secondNumber = 3;
        
        var result = calculator.Add(firstNumber, secondNumber);
        
        Assert.That(result, Is.EqualTo(5));
    }
}