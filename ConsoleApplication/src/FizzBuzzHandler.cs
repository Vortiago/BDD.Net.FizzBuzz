namespace BDD.Net.FizzBuzz
{
    public class FizzBuzzHandler
    {
        public string InputFeedback(int number)
        {
            if (number % 15 == 0)
            {
                return "fizz buzz";
            }
            else if (number % 3 == 0) 
            {
                return "fizz";
            }
            else if (number % 5 == 0) {
                return "buzz";
            }

            return number.ToString();
        }
    }
}
