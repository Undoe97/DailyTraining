using System;

public class StringToInt {
    public int stringToInt(string num_str) {
        int answer = 0;
        
        for(int i=0; i<num_str.Length; i++){
            answer += int.Parse(num_str[i].ToString());    
        }
        return answer;
    }
}