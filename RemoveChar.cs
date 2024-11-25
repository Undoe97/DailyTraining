using System;
using System.Linq;

public class RemoveChar
{
    public string RemoveChars(string str)
    {
        string answer = "";
        answer = new string(str.Distinct().ToArray());
        
        return answer;
    }
}

class RemoveMain
{
    static void Main()
    {
        RemoveChar removeChar = new RemoveChar();
        
        Console.Write("문자열을 입력하세요 : ");
        string input = Console.ReadLine();

        string result = removeChar.RemoveChars(input);
        Console.WriteLine(result);

    }
}