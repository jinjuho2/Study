using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[] { };
        int a = 0;
        int b = 0;

        for (int i = 0; i <num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                 a += 1;
            }
            else
            {
                b += 1;
            }
        }

        answer = new int[] { a , b };
        return answer;
    }
}