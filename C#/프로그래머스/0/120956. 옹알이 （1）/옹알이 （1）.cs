using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        string[] newBabbling = { "aya", "ye", "woo", "ma" };
        string[] newBabbling2 = new string[4];
        for (int i = 0; i < newBabbling.Length; i++)
        {
            foreach (string bab in babbling)
            {
                if (newBabbling[i] == bab)
                {
                    answer++;
                }
            }
            for (int j = 0; j < newBabbling.Length; j++)
            {
                newBabbling2[i] = newBabbling[i] + newBabbling[j];

                foreach (string bab in babbling)
                {
                    if (newBabbling2[i] == bab)
                    {
                        answer++;
                    }
                }
                for (int k = 0; k < newBabbling.Length; k++)
                {
                    newBabbling2[i] = newBabbling[i] + newBabbling[j] + newBabbling[k];

                    foreach (string bab in babbling)
                    {
                        if (newBabbling2[i] == bab)
                        {
                            answer++;
                        }
                    }

                    for (int l = 0; l < newBabbling.Length; l++)
                    {
                        newBabbling2[i] = newBabbling[i] + newBabbling[j] + newBabbling[k] + newBabbling[l];

                        foreach (string bab in babbling)
                        {
                            if (newBabbling2[i] == bab)
                            {
                                answer++;
                            }
                        }
                    }

                }
            }
        }
        return answer;
    }
}