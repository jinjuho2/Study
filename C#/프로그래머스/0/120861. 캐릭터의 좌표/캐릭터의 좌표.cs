using System;

public class Solution
{
    public int[] solution(string[] keyinput, int[] board)
    {
        int a = 0;
        int b = 0;

        int[] answer = new int[2];

        int x = board[0] / 2;
        int y = board[1] / 2;

        foreach (string i in keyinput)
        {
            if (i == "left" && a > -x)
            {
                a--;
            }
            else if (i == "right" && a < x)
            {
                a++;
            }
            else if (i == "up" && b < y)
            {
                b++;
            }
            else if (i == "down" && b > -y)
            {
                b--;
            }
        }

        answer[0] = a;
        answer[1] = b;

        return answer;
    }
}
