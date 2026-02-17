public  class Reference
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

//Contructor with default values
    public Reference()
    {
        _book = "Unknown";
        _chapter = 0;
        _startverse=0;
        _endverse =0;
    }

// Constructor with one verse
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = verse;
        _endverse = verse;
    }
    //Contructor with all the verse
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book=book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    public string readReference()
    {
        if(_startverse == _endverse)
        {
            return $"{_book} {_chapter}:{_startverse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startverse}-{_endverse}";
        }
        
    }
}