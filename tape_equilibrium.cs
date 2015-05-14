// TapeEquilibrium solution. For problem description, see https://codility.com/programmers/lessons/
// Code written in C# 5.0 with .NET 4.5 (Mono)

using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        int sum = A.Sum();
        int right_sum = sum;
        int left_sum = 0;
        int N = A.Length;
        int min_diff = Math.Abs((right_sum - A[0]) - (left_sum + A[0]));
        int diff;
        for (int i=1; i<N; i++) {
            left_sum += A[i-1];
            right_sum -= A[i-1];
            diff = Math.Abs(right_sum - left_sum);
            if (diff < min_diff) {
                min_diff = diff;
            }
        }
        return min_diff;
    }
}
