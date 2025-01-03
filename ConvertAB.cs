using System;
using System.Collections.Generic;

public class ABAB {
    public int abab(string myString, string pat) {
        
        string converted = "";
        foreach(char c in myString){
            if(c == 'A'){
                converted += 'B';
            }
            else{
                converted += 'A';
            }
        }
        return converted.Contains(pat) ? 1 : 0;
    }
}