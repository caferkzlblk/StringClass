using System;

public class String
{
    private string inputString;

    public String(string input)
    {
        inputString = input;
    }

    public string Replace(string ilk, string son)
    {
        if (inputString.Contains(ilk))
        {
            inputString = inputString.Replace(ilk, son);
            return inputString;
        }
        else
        {
            Console.WriteLine(" bulunamadı.");
            return inputString;
        }
    }

    public string Substring(int index, int length)
    {
        if (index >= 0 && index < inputString.Length && length > 0 && index + length <= inputString.Length)
        {
            return inputString.Substring(index, length);
        }
        else
        {
            Console.WriteLine("Geçersiz başlangıç indeksi veya uzunluk.");
            return inputString;
        }
    }

    public string GetResult()
    {
        return inputString;
    }
}

class Program
{
    static void Main()
    {
        // Örnek kullanım
        String myString = new String("YazılımaOrg, OrgYazılıma");

        Console.WriteLine("Orjinal String: " + myString.GetResult());

        // Replace işlemi
        myString.Replace("YazılımaOrg", "OrgYazılıma");
        Console.WriteLine("Replace Sonrası: " + myString.GetResult());

        // Substring işlemi
        string substringResult = myString.Substring(0, 7);
        Console.WriteLine("Substring Sonrası: " + substringResult);
    }
}
