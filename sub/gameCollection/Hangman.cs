namespace gameCollection;

public class Hangman
{
    public void play()
    {
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________________________________________________________");
        Console.WriteLine();
        Console.WriteLine("Welcome to Hangman");
        Console.WriteLine();
        Console.WriteLine("1. Rules");
        Console.WriteLine("2. Start game");
        Console.WriteLine("3. Exit");
        Console.WriteLine();
        
        Console.WriteLine("Type in the name or number of the desired game");
        Console.WriteLine();
        Console.WriteLine(">>>");
        String input = Console.ReadLine();
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
    }

    public void exit()
    {

    }

    private void rules()
    {

    }

    private void game()
    {

    }

}