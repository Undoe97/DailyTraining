using System;

public class StringSorting {
    public int[] stringSorting(string my_string) {
        
        int[] numbers = new int[my_string.Length];
        int count = 0;
        
        for(int i=0; i<my_string.Length; i++){
            if(char.IsDigit(my_string[i])){
                numbers[count] = int.Parse(my_string[i].ToString());
                count++;
            }
        }
        
        Array.Resize(ref numbers, count);
        
        for(int i=0; i<numbers.Length - 1; i++){
            for(int j=i+1; j<numbers.Length; j++){
                if(numbers[i] > numbers[j]){
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        
        return numbers;
    }
}