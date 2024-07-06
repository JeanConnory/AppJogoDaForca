namespace AppJogoForca.Models;

public class Word
{
    public string Tips { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;

    public Word(string tips, string text)
    {
        this.Tips = tips;
        this.Text = text;
    }
}
