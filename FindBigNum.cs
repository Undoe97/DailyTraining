using System;

public class FindBigNum {
    public int[] findBigNum(int[] array) {
        
        int maxNum = array[0];
        int maxIndex = 0;
        
        for(int i=1; i<array.Length; i++){
            if(maxNum < array[i]){
                maxNum = array[i];
                maxIndex = i;
            }
        }
        
        return new int[] {maxNum, maxIndex};

    }
}