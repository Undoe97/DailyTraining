using System;
using System.Collections.Generic;

public class Betweenx {
    public int[] betweenx(string myString) {
        // "x"를 기준으로 문자열을 나누기
        string[] splitStrings = myString.Split('x');
        
        // 나눠진 문자열 각각의 길이를 저장
        int[] result = new int[splitStrings.Length];
        for (int i = 0; i < splitStrings.Length; i++) {
            result[i] = splitStrings[i].Length;
        }
        
        return result;
    }
}