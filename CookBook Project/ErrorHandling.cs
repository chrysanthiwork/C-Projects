public class ErrorHandling
{
	public static bool WrongInputType(string input)
	{
        if (int.TryParse(input, out int result))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
