using System;

public class CompareDate {
    public int comparedate(int[] date1, int[] date2) {
       
        for(int i = 0; i < 3; i++){
            if(date1[i] < date2[i]){
                return 1;
            }
            if(date1[i] > date2[i]){
                return 0;
            }
        }
        return 0;
    }
}