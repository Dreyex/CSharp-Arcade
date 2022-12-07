namespace gameCollection;

using sub;

public class Hangman
{
    //attributes
    String[,] logo = new String[5,1]
    {
        {"  ██   ██  █████  ███    ██  ██████  ███    ███  █████  ███    ██  "},  
        {"  ██   ██ ██   ██ ████   ██ ██       ████  ████ ██   ██ ████   ██  "},  
        {"  ███████ ███████ ██ ██  ██ ██   ███ ██ ████ ██ ███████ ██ ██  ██  "},
        {"  ██   ██ ██   ██ ██  ██ ██ ██    ██ ██  ██  ██ ██   ██ ██  ██ ██  "},
        {"  ██   ██ ██   ██ ██   ████  ██████  ██      ██ ██   ██ ██   ████  "},
    };

    String[,] dExit = new String[5,1]
    {
        {"   ██████   ██████   ██████  ██████  ██████  ██    ██ ███████  "},
        {"  ██       ██    ██ ██    ██ ██   ██ ██   ██  ██  ██  ██       "},
        {"  ██   ███ ██    ██ ██    ██ ██   ██ ██████    ████   █████    "},
        {"  ██    ██ ██    ██ ██    ██ ██   ██ ██   ██    ██    ██       "},
        {"   ██████   ██████   ██████  ██████  ██████     ██    ███████  "}, 
    };



    //methods
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
        
        Console.WriteLine("Type in the name or number of the desired game");
        Console.WriteLine();
        Console.WriteLine(">>>");
        String input = Console.ReadLine() + "";
        Console.WriteLine("<<<");
        Console.WriteLine();

        if(input.Equals("1") || input.Equals("Rules") || input.Equals("1"))  
        {
            rules();
        }  
        else if(input.Equals("2") || input.Equals("Start Game") || input.Equals("2")) 
        {
            game();
        }
        else if(input.Equals("3") || input.Equals("Exit") || input.Equals("3"))  
        {
            exit();
        }
        else if(input.Equals("4") || input.Equals("Direct exit") || input.Equals("4"))  
        {
            directExit();
        }
    }

    public void exit()
    {
        Arcade arc = new Arcade(); 
        arc.menu();
    }

    public void directExit()
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

    private void rules()
    {

    }

    private void game()
    {
        int guessedWrong = 0;
        String wrongLetters = "";
        String word = wordChooser();
        String hidden = wordHider(word);
        //Console.WriteLine(word);
        //Console.WriteLine(hidden);
        char[] wordA = word.ToCharArray();          //word as Char-Array 
        char[] hiddenA = hidden.ToCharArray();     //hidden word as Char-Array 

        String[,] man = new String[,]           //Hangman 
        { 
            
        };


    }

    private String wordChooser()
    {
        String[] lines = File.ReadAllLines("C:\\Users\\user802\\Documents\\Cyberspace\\CSharp-Arcade\\sub\\gameCollection\\wordList\\wordList.txt");
        Random rand = new Random();
        return lines[rand.Next(0, lines.Length - 1)];
    }

    private String wordHider(String word)
    {
        String hidden = "";
        for(int i = 0; i < word.Length; i++)
        {
            hidden += "_";
        }
        return hidden;
    }

}