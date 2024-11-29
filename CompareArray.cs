using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        
        int arr1sum = 0;
        int arr2sum = 0;
        // 두 배열의 길이가 긴 쪽이 크다
        if(arr1.Length > arr2.Length){
            answer = 1;
        }
        else if(arr2.Length > arr1.Length){
            answer = -1;
        }
        // 배열의 길이가 같다면 모든 원소의 합 비교
        else{
            for(int i=0; i<arr1.Length; i++){
                arr1sum += arr1[i];
                arr2sum += arr2[i];
            }
            
            if(arr1sum > arr2sum){
                answer = 1;
            }
            else if(arr2sum > arr1sum){
                answer = -1;
            }
            else{
                answer = 0;
            }
        }        
        
        return answer;
    }
}