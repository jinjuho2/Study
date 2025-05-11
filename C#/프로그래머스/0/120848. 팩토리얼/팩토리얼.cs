using System;

public class Solution {
    public int solution(int n) {
        int answer ;
        int a = 1;
        int i = 1;
        while (n >= i)
        {
            a++;
            i *= a;
        }
        
        
        return answer = a - 1;
    }
}