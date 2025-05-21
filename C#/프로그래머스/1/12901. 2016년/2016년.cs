public enum day
{
    SUN,
    MON,
    TUE,
    WED,
    THU,
    FRI,
    SAT,
}

public class Solution
{
    public string solution(int a, int b)
    {
        int[] monthDays = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string answer = "";
        int sum =0;
        for (int i = 0; i < a -1 ; i++)
        {
            sum += monthDays[i];
        }

        sum += b;

        sum = (sum + 5- 1) % 7;

        answer = ((day)sum).ToString();
        return answer;
    }
}