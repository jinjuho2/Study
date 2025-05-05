using System;

public class Solution
{
    public int solution(int slice, int n)
    {
        int answer = 1;
        int origin = slice;

        while (true)
        {
            if (slice / n == 0)
            {
                slice += origin;
                answer++;
            }
            else break;

        }

        return answer;
    }
}