using System;

public class Solution
{
    public int solution(int[] array, int height)
    {
        int answer = 0;
        foreach (int i in array)
        {
            if (i > height)
            {
                answer++;
            }
        }
        return answer;
    }
}