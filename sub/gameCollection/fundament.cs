namespace gameCollection;

using sub;

public abstract class fundament
{
    //standard attributes
    String[,] logo = new String[5,1]
    {
        {""},  
        {""},  
        {""},
        {""},
        {""},
    };  //logo displayed when on game site - no values cause they get designed in the specialized  classes
    String[,] dExit = new String[5,1]   //standard exit logo
    {
        {"   ██████   ██████   ██████  ██████  ██████  ██    ██ ███████  "},
        {"  ██       ██    ██ ██    ██ ██   ██ ██   ██  ██  ██  ██       "},
        {"  ██   ███ ██    ██ ██    ██ ██   ██ ██████    ████   █████    "},
        {"  ██    ██ ██    ██ ██    ██ ██   ██ ██   ██    ██    ██       "},
        {"   ██████   ██████   ██████  ██████  ██████     ██    ███████  "}, 
    };

    //standard methods
    public void play()  //mein method to start
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
        Console.WriteLine();

        if(input.Equals("1") || input.Equals("Rules"))  
        {
            rules();
        }  
        else if(input.Equals("2") || input.Equals("Start Game")) 
        {
            game();
        }
        else if(input.Equals("3") || input.Equals("Exit"))  
        {
            exit();
        }
        else if(input.Equals("4") || input.Equals("Direct exit"))  
        {
            directExit();
        }
        else
        {
            Console.WriteLine("Invalid input - Please try again");
            play();
        }
    }

    protected void exit()
    {
        Arcade arc = new Arcade(); 
        arc.menu();
    }

    private void directExit()
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
    protected abstract void rules();
    protected abstract void game();

    private void setLogo(String[,] a)
    {
        //set logo
        logo = a;
    }
}