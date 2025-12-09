namespace Y10_RobustProgramming
{
    internal class Program
    {
        static void ValidationChecks()
        {
            string username = Console.ReadLine()!;
            string password = Console.ReadLine()!;
            int age = Convert.ToInt32(Console.ReadLine()!);
            //range check
            while (age < 1 || age > 120) // while age is not valid
            {
                Console.WriteLine("Age is unreasonable, please enter again.");
                age = Convert.ToInt32(Console.ReadLine()!);
            }

            //length check
            while (password.Length < 7 || password.Length > 50)
            {
                Console.WriteLine("Password is not the correct length");
                password = Console.ReadLine()!;
            }

            //presence check
            while (username == "") //checks if it is blank
            {
                Console.WriteLine("You must enter data for username");
                username = Console.ReadLine()!;
            }
        }

        static void VerifyDetails()
        {
            string user = "nayekz22";
            string pass = "password123";
            Console.Write("Enter username: ");
            string username = Console.ReadLine()!;
            Console.Write("Enter password: ");
            string password = Console.ReadLine()!;
            //validate username
            while (username == "") //checks if it is blank
            {
                Console.WriteLine("You must enter data for username");
                username = Console.ReadLine()!;
            }
            while (username != user)
            {
                Console.Write("Username is not in our records, please enter a valid username: ");
                username = Console.ReadLine()!;
            }
            //validate password
            while (password.Length < 7 || password.Length > 50)
            {
                Console.WriteLine("Password is not the correct length");
                password = Console.ReadLine()!;
            }
            while (password != pass)
            {
                Console.Write("Invalid password, please re-enter: ");
                password = Console.ReadLine()!;
            }
            Console.WriteLine("Enter your credentials again");
            Console.Write("Enter username: ");
            username = Console.ReadLine()!;
            Console.Write("Enter password: ");
            password = Console.ReadLine()!;

        }
        static void Main(string[] args)
        {
            VerifyDetails();
        }
    }
}
