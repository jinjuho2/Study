using System;

public class Solution
{
    public int solution(int[,] dots)
    {
        int answer = 0;
        int x = Math.Abs(dots[0, 0] - dots[1, 0]);
        int y = Math.Abs(dots[0, 1] - dots[2, 1]);

        if (x == 0 || y == 0)
        {
            x = Math.Abs(dots[0, 0] - dots[2, 0]);
            y = Math.Abs(dots[0, 1] - dots[1, 1]);
        }


        answer = x * y;


        return answer;
    }
}