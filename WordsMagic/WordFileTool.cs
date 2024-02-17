namespace WordsMagic;

public class WordFileTool
{
    private readonly List<string> _words = new();

    public WordFileTool()
    {
        FileStream f = File.Open("words.txt",FileMode.Open,FileAccess.Read);
        StreamReader reader = new(f);
        string? r;
        while((r=reader.ReadLine())!=null)
        {
            _words.Add(r);
        }
        reader.Close();
        reader.Dispose();
        f.Close();
        f.Dispose();
    }

    public bool DoesContainWord(string word) => _words.Contains(word);
}