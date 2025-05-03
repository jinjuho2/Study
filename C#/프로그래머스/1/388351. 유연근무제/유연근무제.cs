using System;

public class Solution
{
    public int solution(int[] schedules, int[,] timelogs, int startday)
    {
        int answer = 0;
        int ok = 0;
        int th = 0;
        int tm = 0;

        for (int i = 0; i < schedules.Length; i++)
        {

            schedules[i] += 10;
            th = schedules[i] / 100;
            tm = schedules[i] % 100;
            if ( tm >= 60)
            {
                tm -= 60;
                th++;
            }
            schedules[i] = th * 100 + tm;
        }

        for (int i = 0; i < schedules.Length; i++)
        {
            int day = startday;
            for (int n = 0; n < 7; n++)
            {
                if (day > 7)
                {
                    day = 1;
                }
                if (schedules[i] >= timelogs[i, n] && day < 6)
                {
                    ok++;
                }
                day++;
            }

            if (ok >= 5)
            {
                answer++;
            }

            ok = 0;
        }

        return answer;
    }
}