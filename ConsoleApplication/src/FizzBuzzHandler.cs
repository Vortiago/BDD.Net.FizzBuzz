namespace BDD.Net.FizzBuzz
{
    public class FizzBuzzHandler
    {
        public string InputFeedback(int number)
        {
            if (number % 3 == 0) 
            {
                return "fizz";
            }
            return number.ToString();
        }
    }
}
