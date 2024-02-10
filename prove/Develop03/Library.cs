public class Library
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _scriptureText;

    public void SetScripture(int option)
    {
        switch (option)
        {
            case 1:
            _book = "Genesis";
            _chapter = 1;
            _startVerse = 1;
            _endVerse = 3;
            _scriptureText = "In the beginning, God created the heavens and the earth. The earth was without form and void, and darkness was over the face of the deep. And the Spirit of God was hovering over the face of the waters.";
            break;
        case 2:
            _book = "John";
            _chapter = 3;
            _startVerse = 16;
            _endVerse = 16;
            _scriptureText = "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.";
            break;
        case 3:
            _book = "Romans";
            _chapter = 8;
            _startVerse = 28;
            _endVerse = 30;
            _scriptureText = "And we know that for those who love God all things work together for good, for those who are called according to his purpose. For those whom he foreknew he also predestined to be conformed to the image of his Son, in order that he might be the firstborn among many brothers. And those whom he predestined he also called, and those whom he called he also justified, and those whom he justified he also glorified.";
            break;
        case 4:
            _book = "Psalms";
            _chapter = 23;
            _startVerse = 1;
            _endVerse = 6;
            _scriptureText = "The Lord is my shepherd; I shall not want. He makes me lie down in green pastures. He leads me beside still waters. He restores my soul. He leads me in paths of righteousness for his name's sake. Even though I walk through the valley of the shadow of death, I will fear no evil, for you are with me; your rod and your staff, they comfort me. You prepare a table before me in the presence of my enemies; you anoint my head with oil; my cup overflows. Surely goodness and mercy shall follow me all the days of my life, and I shall dwell in the house of the Lord forever.";
            break;
            default:
                _book = "";
                _chapter = 0;
                _startVerse = 0;
                _endVerse = 0;
                _scriptureText = "";
                break;
        }
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public string GetScriptureText()
    {
        return _scriptureText;
    }
}