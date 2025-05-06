using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        int slice = 7;
        int origin = slice;
        
        while (slice / n <= 0)
        {
            slice += origin;
            answer++;
        }
        return answer;
    }
}