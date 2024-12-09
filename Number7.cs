using System;

public class Num7 {
    public int numseven(int[] array) {
        int count = 0;
        
        foreach (int num in array) {
            // 숫자를 문자열로 변환 후 '7'의 개수를 카운트
            string numStr = num.ToString();
            foreach (char c in numStr) {
                if (c == '7') {
                    count++;
                }
            }
        }
        
        return count;
    }
}