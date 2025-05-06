using System;

public class Solution
{
    public int[] solution(int money)
    {
        int[] answer = new int[] { };
        int ame = 5500;
        int a = 0;
        while (true)
        {
            if (money < ame)
                break;
            a++;
            money -= ame;

        }
        answer = new int[] { a, money }
        ;
        return answer;
    }
}