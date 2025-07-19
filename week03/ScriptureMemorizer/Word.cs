using System;
public class Word
{
    private String _text;
    private Boolean _isHidden;

    public Word(String text)
    {
        _text = text;
        _isHidden = false;
    }

    public String GetDisplayText()
    {
        return _text;
    }

    public Boolean IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
}