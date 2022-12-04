namespace tool;

public class Arcade
{
    //attributes
    String[] games = new String[]{"Rock-Paper-Scisscor", "Tic-Tac-Toe", "Connect 4", "Hangman"};

    //methods
    public void menu()
    {
        String[,] logo = new String[8,1]
        {
          {" _________________________________________________________"},  //ARCADE
          {"|   ______   ______   ______   ______   _____    ______   |"},  
          {"|  |  __  | |  __  | |  ____| |  __  | |  __ -  |  ____|  |"},
          {"|  | |  | | | |__| | | |      | |  | | | |  | | | |____   |"},
          {"|  | |__| | |    __| | |      | |__| | | |  | | |  ____|  |"},
          {"|  |  __  | | ||_|_  | |____  |  __  | | |__| | | |____   |"},
          {"|  |_|  |_| |_|  |_| |______| |_|  |_| |_____-  |______|  |"}, 
          {"|_________________________________________________________|"}
        };

        for(int i = 0; i < logo.GetLength(0); i++)
        {
            //Console.WriteLine(logo.GetLength(1));
            //Console.WriteLine(logo.GetLength(2));
            Console.WriteLine(logo[i,0]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Welcome to the main menu!");
        Console.WriteLine();
        Console.WriteLine("1. View Game List");
        Console.WriteLine("2. Create Account");
        Console.WriteLine("3. Login to Account");
        Console.WriteLine("4. Logout from Account");
        Console.WriteLine("4. View Account");
        Console.WriteLine("5. View Statistics");
        Console.WriteLine();
        Console.WriteLine("Please enter the number of the desired action");
        Console.WriteLine();
        redirection();
    }

    private void exit()
    {
        Console.WriteLine("Goodbye");
    }

    private void redirection()
    {
        Console.WriteLine(">>>");
        String input = Console.ReadLine();
        int choice = Int32.Parse(input);
        Console.WriteLine("<<<");

        if(choice > 6) 
        {
            Console.WriteLine("ERROR --- Please try another Number");
            Console.WriteLine();
            redirection();
        }
        else if(choice == 1)
        {
            foreach (String i in games)
            {
                Console.WriteLine($"{i}");
            }
        }
        else if(choice > 1)
        {
            Console.WriteLine("___///------///___Under Construction___///------///___");
            Console.WriteLine();
            redirection();
        }

    }





    //constructors


}