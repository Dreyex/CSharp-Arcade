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

    int guessedWrong = 0; //maximum 8 wrong guesses
    int guessedRight = 0; //maximum  length of the word
    String wrongLetters = "";
    String word;
    String hidden;
    char[] wordA;       //word as Char-Array 
    char[] hiddenA;     //hidden word as Char-Array 
    String guess;


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

    private void game()     //Fehler beim Vergleich der Arrays hiddenA und wordA
                            //Idee: Zähler für richtige Buchstaben und dann Vergleich mit Länge des Wortes (wordA)
                            //      da der Vergleich der Arrays nicht funktioniert aber der Zahlenvergleich für falsche Buchstaben
    {   
        //get a value for the attributes
        word = wordChooser().ToUpper();     //get a word to guess
        hidden = wordHider(word);           //hide the word from the screen
        wordA = word.ToCharArray();         //convert word to array
        hiddenA = hidden.ToCharArray();     //convert hidden to array
        Console.WriteLine(word);
        while(guessedRight != wordA.Length && guessedWrong != 8)
        {
            Console.WriteLine("----------------------------------------");
            hangman(guessedWrong);  //displays the current state of the Hangman
            Console.WriteLine("Wrong Letters: " + wrongLetters);
            Console.WriteLine("Word to guess: ");
            foreach(char i in hiddenA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please input a letter: ");
            ConsoleKeyInfo key = Console.ReadKey(); //gets the pressed key
            char input = key.KeyChar;               //converts it to a char
            input = char.ToUpper(input); //converts it to Uppercase 
            Console.WriteLine();   
            //for(int i = 0; i < wordA.Length; i++)
            //{
            compare(input);
            //} 
            // for(int i = 0; i < hiddenA.Length; i++)
            // {
            //     Console.WriteLine("wordA: " + wordA[i]);    
            //     Console.WriteLine("HiddenA: " + hiddenA[i]);  
            // } 
            
        }
        if(guessedWrong == 8)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            hangman(guessedWrong);
            Console.WriteLine("Game Over"); 
            Console.WriteLine("The word was: " + word);      
            Console.WriteLine("Guessed Wrong: " + guessedWrong);
            Console.WriteLine("Wrong guessed Letters: " + wrongLetters);
            guessedWrong = 0;
            guessedRight = 0;
            wrongLetters = "";
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            play();
        }
        else if(guessedRight == wordA.Length)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("You Won!"); 
            Console.WriteLine("The word was: " + word);      
            Console.WriteLine("Guessed Wrong: " + guessedWrong);
            Console.WriteLine("Wroong guessed Letters: " + wrongLetters);
            guessedWrong = 0;
            guessedRight = 0;
            wrongLetters = "";
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            play();
        }
    }

    private void compare(char inp)
    {
        if(wordA.Contains(inp))
        {
            for(int i = 0; i < wordA.Length; i++)
            {
                if(inp == wordA[i])
                {
                    hiddenA[i] = inp;
                    guessedRight++;
                }
            }
        }
        else
        {
            if(wrongLetters.Contains(inp))
            {

            }
            else
            {
                guessedWrong++;
                wrongLetters += inp;
            }
        }
    }

    private String wordChooser()    //chooses a random word rom a very big list of words
    {
        String[] lines = File.ReadAllLines("sub\\gameCollection\\wordlist\\wordList.txt");    //reads every line of a file and for each line it saves the value in an array
        Random rand = new Random();                         //get a random number             //^relative path to the txt file
        return lines[rand.Next(0, lines.Length - 1)];       //from the given dimensions
    }

    private String wordHider(String word)       //hides word with "_" to display the word 
    {
        String hidden = "";
        for(int i = 0; i < word.Length; i++)
        {
            hidden += "_";
        }
        return hidden;
    }

    private void hangman(int guessesWrong)      //displays the hangman based on the wrong guessed letters
    {
        if (guessesWrong == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   |_______");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |_______");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("   ________");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |_______");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 5)
        {
            Console.WriteLine("");
            Console.WriteLine("   ________");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |      O");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |_______");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 6)
        {
            Console.WriteLine("");
            Console.WriteLine("   ________");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |      O");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |_______");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 7)
        {
            Console.WriteLine("");
            Console.WriteLine("   ________");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |      O");
            Console.WriteLine("   |     /|\\");
            Console.WriteLine("   |");
            Console.WriteLine("   |");
            Console.WriteLine("   |_______");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }
        else if (guessesWrong == 8)
        {
            Console.WriteLine("");
            Console.WriteLine("   ________");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |      O");
            Console.WriteLine("   |     /|\\");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |     / \\ ");
            Console.WriteLine("   |_______");
            Console.WriteLine("   |       \\");
            Console.WriteLine("   |________|");
            Console.WriteLine("");
        }

       

    }

}