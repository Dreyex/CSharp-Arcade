namespace gameCollection;

using sub;

public class Connect4
{
    //attributes
    static int height = 6;  //height of the grid
    static int width = 7;   //width of the grid
    String [,] grid = new String[height,width];  //grid for the 4-Connect game
    static String player1 = "X";   //player 1's symbol
    static String player2 = "O";   //player 2's symbol

    String [,] logo = new String[5,1]  //logo for the 4-Connect game
    {
        {"  ██████  ██████  ███    ██ ███    ██ ███████  ██████ ████████       ██   ██  "},
        {" ██      ██    ██ ████   ██ ████   ██ ██      ██         ██          ██   ██  "},
        {" ██      ██    ██ ██ ██  ██ ██ ██  ██ █████   ██         ██    █████ ███████  "},
        {" ██      ██    ██ ██  ██ ██ ██  ██ ██ ██      ██         ██               ██  "},
        {"  ██████  ██████  ██   ████ ██   ████ ███████  ██████    ██               ██  "}
    };

    String[,] dExit = new String[5,1]   //Exit-logo for the 4-Connect game
    {
        {"   ██████   ██████   ██████  ██████  ██████  ██    ██ ███████  "},
        {"  ██       ██    ██ ██    ██ ██   ██ ██   ██  ██  ██  ██       "},
        {"  ██   ███ ██    ██ ██    ██ ██   ██ ██████    ████   █████    "},
        {"  ██    ██ ██    ██ ██    ██ ██   ██ ██   ██    ██    ██       "},
        {"   ██████   ██████   ██████  ██████  ██████     ██    ███████  "}, 
    };

    //methods

        //main method to start
    public void play()
    {
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________________________________________________________");
        Console.WriteLine();
        for(int i = 0; i < logo.GetLength(0); i++)
        {
            Console.WriteLine(logo[i,0]);
        }
        Console.WriteLine();
        Console.WriteLine("1. Rules");
        Console.WriteLine("2. Start game");
        Console.WriteLine("3. Exit");
        Console.WriteLine("4. Direct exit");
        Console.WriteLine();
        
        Console.WriteLine("Type in the name or number of the desired Action");
        Console.WriteLine();
        Console.WriteLine(">>>");
        String input = Console.ReadLine() + "";
        Console.WriteLine("<<<");
        Console.WriteLine("");
    }
    //method to create the grid


}