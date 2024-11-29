using System;
using System.Linq;

public class NoAD {
    public string[] noAD(string[] strArr) {
        
        string[] answer = strArr.Where(str => !str.Contains("ad")).ToArray();
    
        return answer;
    }
}