using System;
using System.Collections.Generic;

public class OneTimePassword
{
    static private string[] w1  = {"Liten", "Stor", "Mega", "Flott", "Tullete", "Kravstor", "Enkel"};
    private static string[] w2  = {"Mann", "Dame", "Gutt", "Jente", "Hund", "Nabo", "Ansatt", "Katt", "Plante"};

    public static string Phrase()
    {
        var s1 = w1[new Random().Next(w1.Length-1)];
        var s2 = w2[new Random().Next(w2.Length-1)];
        return $"{s1} {s2}";
    }

    public static List<string> Keys = new List<string>();
}