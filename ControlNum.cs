using System;

public class Solution
{
    public int ControlNum(int n, string control)
    {
        foreach (char c in control)
        {
            switch (c)
            {
                case 'w':
                    n += 1;
                    break;
                case 's':
                    n -= 1;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
            }
        }
        return n;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        // 초기 값 n과 control 문자열 입력받기
        Console.Write("정수 n을 입력하세요: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("control 문자열을 입력하세요: ");
        string control = Console.ReadLine();

        // 결과 출력
        int result = sol.ControlNum(n, control);
        Console.WriteLine($"최종 결과: {result}");
    }
}