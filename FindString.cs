using System;

public class FindString {
    public int findString(string myString, string pat) {
        int answer = 0;
        
        if(myString.Contains(pat, StringComparison.OrdinalIgnoreCase)){
            answer = 1;
        }
        else{
            answer = 0;
        }
        
        return answer;
    }
}