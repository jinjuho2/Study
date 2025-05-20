using System;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        int sum = 0;
        int b = 0;
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        int[] count = new int[max + 1];
        for (int i = 0; i < count.Length; i++)
        {
            if (array.Length == 1)
            {
                answer = array[0];
                break;
            }
            foreach (int a in array)
            {
                if (i == a)
                {
                    sum++;
                }
            }
            if (b < sum)
            {
                b = sum;
                answer = i;
            }
            else if (b == sum)
            {
                answer = -1;
            }
            sum = 0;
        }
        return answer;
    }
}
