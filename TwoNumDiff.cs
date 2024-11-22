using System;

public class Solution
{
    public int solution(int num1, int num2)
    {
        return num1 - num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        Console.Write("첫 번째 숫자를 입력하세요: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("두 번째 숫자를 입력하세요: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = sol.solution(num1, num2);
        Console.WriteLine($"결과: {result}");
    }
}