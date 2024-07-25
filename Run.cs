using BookManagement.Functions;

class Run
{
    static void Main(string[] args)
    {
        while (true)
        {   
            int userid = -1;

            Console.WriteLine("Exit|Log in|Sign up [0|1|2]");
            Console.Write("Option:");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 0)
            {
                Console.WriteLine("Bye!");
                break;
            }
            else if (option == 1)
            {
                userid = Functions.login();

                if (userid == -1)
                {
                    Console.WriteLine("Username or password is incorrect");
                }
            }
            else if (option == 2)
            {
                userid = Functions.signup();

                if (userid == -1)
                {
                    Console.WriteLine("Username or email already used");
                }
            }

            while (userid != -1)
            {
                Console.WriteLine("========Home Page=========");

                Console.WriteLine("Log out|See Books|Add Book [0|1|2]");
                Console.Write("option: ");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 0)
                {
                    break;
                }

                else if (option == 1) 
                {
                    Functions.seebooks();
                }
                else if (option == 2){
                    
                    Functions.addbook();
                }
            }
        }
    }
}