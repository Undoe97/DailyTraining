using System;

public class FiveNum {
    public int[] fiveNum(int[] num_list) {
        int[] answer = new int[] {0, 0, 0, 0, 0};
        
        Array.Sort(num_list);
        
        for(int i=0; i<5; i++){
            answer[i] = num_list[i];
        }
        
        return answer;
    }
}