using System;

public class SwapString {
    public string swapString(string my_string, int num1, int num2) {
        char[] charArray = my_string.ToCharArray();
        
        char temp = charArray[num1];
        charArray[num1] = charArray[num2];
        charArray[num2] = temp;
        
        return new string(charArray);
        
    }
}