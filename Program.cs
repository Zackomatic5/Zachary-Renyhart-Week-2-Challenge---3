namespace Zachary_Renyhart_Week_2_Challenge___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string storedUsername = "Zachary"; //Const means it cant be changed 
            const string storedPassword = "password7";
            bool success = false; //This makes it a true or false value

            for (int i = 1; i <= 3; i++) //This starts the loop at 1 and ends it at 3.

            {
                Console.WriteLine("Please enter your username: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Please enter your password: ");
                string password = Console.ReadLine();

                if (userName == storedUsername && password == storedPassword)
                {
                    success = true; //If the username is correct it will immediately go to the if loop and promp "Access granted"
                    break;
                }
            }

            if (success)
            {
                Console.WriteLine("Welcome! You have been granted access!!");
            }
            else
            {
                Console.WriteLine("You have been blocked!!!"); //If the user fails 3 times, they will be prompted "You have been blocked"
            }

        }
    }
}
