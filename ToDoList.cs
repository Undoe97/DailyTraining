using System;
using System.Collections.Generic;

public class ToDoList {
    public string[] toDoList(string[] todo_list, bool[] finished) {
        List<string> answerList = new List<string>();
        
        for (int i = 0; i < todo_list.Length; i++) {
            if (!finished[i]) {
                answerList.Add(todo_list[i]); // 완료되지 않은 항목만 추가
            }
        }
        
        return answerList.ToArray(); // List를 배열로 변환하여 반환
    }
}