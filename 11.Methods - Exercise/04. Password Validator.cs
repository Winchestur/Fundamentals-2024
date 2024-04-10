
internal class Program
{
    private static void Main(string[] args)
    {
        string password = Console.ReadLine();

        checkIfPasswordIsValid(password);
    }

    private static void checkIfPasswordIsValid(string password)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
        int digit;

        int countDigit = 0;
        int error = 0;
        int lettersAndDigit = 0;
        int countString = 0;
        bool istrue;

        foreach (char item in password)
        {

            if (password.Length < 6 && error == 0 || password.Length > 10 && error == 0)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                error = 1;
            }
            if (password.Length < 6 || password.Length > 10)
            {
                if (istrue = int.TryParse(item.ToString(), out digit))
                {
                    countDigit++;
                }
                else if (alpha.Contains(item))
                {
                    countString++;
                }
                else
                {
                    if (lettersAndDigit < 1)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        lettersAndDigit++;
                    }
                }
            }
            else if (password.Length >= 6 && password.Length <= 10)
            {

                if (istrue = int.TryParse(item.ToString(), out digit))
                {
                    countDigit++;
                }
                else if (alpha.Contains(item))
                {
                    countString++;
                }
                else
                {
                    if (lettersAndDigit < 1)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        lettersAndDigit++;
                    }
                }
            }

        }
        if (countDigit < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }
        else if (lettersAndDigit == 0 && countDigit >= 2 && countString + countDigit >= 6 && countString + countDigit <= 10)
        {
            Console.WriteLine("Password is valid");
        }

    }
}


