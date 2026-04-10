using _08_StatiClassExtensionMethodsExceptions;

class Program
{
    static void Main(string[] args)
    {
        LoginSystem system = new LoginSystem();

        while (true)
        {
            try
            {
                Console.WriteLine("Username:");
                string username = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();

                if (system.Login(username, password))
                {
                    break;
                }
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                system.ShowAllUsers();
            }
            catch (IncorrectPasswordException ex)
            {
                Console.WriteLine("Warning :" + ex.Message);
            }
            catch (AccountLockedException ex)
            {
                Console.WriteLine("Critical :" + ex.Message + "Please contact admin.");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UNEXPECTED ERROR:" + ex.Message);
            }
        }
        Console.WriteLine("Sistem baglandi.");
    }
}