using System;

public class Solution
{
    public int[] solution(int num, int total)
    {
        int[] answer = new int[num];
        int sum = 0;
        int array = 0;
        int number = -1000;
        while (true)
        {
            for (int i = number; i < num + number; i++)
            {
                sum += i;
                answer[array] = i;
                array++;
            }

            if (sum == total)
                break;
            sum = 0;
            array = 0;
            number++;
        }
        return answer;
    }
}