using System;
using System.Collections.Generic;

public class Divisor {
    public int[] divisor(int n) {
        int[] answer = new int[] {};
        
        List<int> list = new List<int> {};
        
        // 나머지가 0인 값, 약수
        for(int i=1; i<=n; i++){
            if(n % i == 0){
                list.Add(i);
            }
        }
        
        answer = list.ToArray();
        
        return answer;
    }
}