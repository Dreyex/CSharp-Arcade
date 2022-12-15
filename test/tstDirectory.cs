namespace test;

public class Tst
{
    String curDir = Directory.GetCurrentDirectory(); //absoluter Pfad bis zum derzeitigen Ordner
    String relDir = "\\sub\\gameCollection\\wordlist\\wordList.txt"; //relativer Pfad

    

    public void output()
    {
        Console.WriteLine(curDir);
        Console.WriteLine(relDir);
    }
    
}