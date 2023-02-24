namespace sub;

using gameCollection;

public class Arcade
{
    //attributes
    String[] gameList = new String[]{"Rock-Paper-Scisscor", "Tic-Tac-Toe", "Connect 4", "Hangman"};
    String[,] logo = new String[5,1]
            {    
                {"   █████  ██████   ██████  █████  ██████  ███████  "},
                {"  ██   ██ ██   ██ ██      ██   ██ ██   ██ ██       "},
                {"  ███████ ██████  ██      ███████ ██   ██ █████    "},
                {"  ██   ██ ██   ██ ██      ██   ██ ██   ██ ██       "},
                {"  ██   ██ ██   ██  ██████ ██   ██ ██████  ███████  "}, 
            };
    String[,] dExit = new String[5,1]
            {  
                {"   ██████   ██████   ██████  ██████  ██████  ██    ██ ███████  "},
                {"  ██       ██    ██ ██    ██ ██   ██ ██   ██  ██  ██  ██       "},
                {"  ██   ███ ██    ██ ██    ██ ██   ██ ██████    ████   █████    "},
                {"  ██    ██ ██    ██ ██    ██ ██   ██ ██   ██    ██    ██       "},
                {"   ██████   ██████   ██████  ██████  ██████     ██    ███████  "},
            };

    String[,] gList = new String[5,1]
            {  
                {"  ██████   █████  ███    ███ ███████     ██      ██ ███████ ████████ "},
                {" ██       ██   ██ ████  ████ ██          ██      ██ ██         ██    "},
                {" ██   ███ ███████ ██ ████ ██ █████       ██      ██ ███████    ██    "},
                {" ██    ██ ██   ██ ██  ██  ██ ██          ██      ██      ██    ██    "},
                {"  ██████  ██   ██ ██      ██ ███████     ███████ ██ ███████    ██    "},
            };

    //methods
    public void menu()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
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
        Console.WriteLine("5. View Account");
        Console.WriteLine("6. View Statistics");
        Console.WriteLine("7. Exit");
        Console.WriteLine();
        Console.WriteLine("Please enter the number of the desired action");
        Console.WriteLine();
        redirection();
    }

    private void exit()
    {
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________________________________________________________");
        Console.WriteLine();
        for(int i = 0; i < dExit.GetLength(0); i++)
        {
            Console.WriteLine(dExit[i,0]);
        }
        Console.WriteLine("__________________________________________________________________________________________________________");
        Console.WriteLine();
    }

    public void redirection()
    {
        Console.WriteLine(">>>");
        String input = Console.ReadLine() + "";
        int choice = Int32.Parse(input);
        Console.WriteLine("<<<");

        if(choice > 7) 
        {
            Console.WriteLine("ERROR --- Please try another Number");
            Console.WriteLine();
            redirection();
        }
        else if(choice == 1)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for(int i = 0; i <  gList.GetLength(0); i++)
            {
                Console.WriteLine(gList[i,0]);
            }
            Console.WriteLine();
            Console.WriteLine();
            int j = 1;
            foreach (String i in gameList)
            {
                Console.WriteLine( j + ". "+ $"{i}");
                j++;
            }
            Console.WriteLine();
            gameChoice();
        }
        else if(choice == 7)
        {
            exit();
        }
        else if(choice > 1 && choice != 7)
        {
            Console.WriteLine("___///------///___Under Construction___///------///___");
            Console.WriteLine();
            redirection();
        }

    }

    private void gameChoice()
    {
        Console.WriteLine("Type in the name or number of the desired game");
        Console.WriteLine();
        Console.WriteLine(">>>");
        String input = Console.ReadLine() + "";
        Console.WriteLine("<<<");

            if (input.Equals(gameList[0]) || input.Equals("1"))
            {
                Console.WriteLine("___///------///___Under Construction___///------///___");
                Console.WriteLine();
                gameChoice();
            }
            else if (input.Equals(gameList[1]) || input.Equals("2"))
            {
                Console.WriteLine("___///------///___Under Construction___///------///___");
                Console.WriteLine();
                gameChoice();
            }
            else if (input.Equals(gameList[2]) || input.Equals("3"))
            {
                Connect4 game = new Connect4();
                game.play();
            } 
            else if (input.Equals(gameList[3]) || input.Equals("4"))
            {
                Hangman game = new Hangman();
                game.play();
            }
    }





    //constructors


}