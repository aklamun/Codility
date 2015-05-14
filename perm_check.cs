// PermCheck solution. For problem description, see https://codility.com/programmers/lessons/2
// Code written in C# 5.0 with .NET 4.5 (Mono)

using System;

class Solution {
    public int solution(int[] A) {
        int N = A.Length;
        int[] count = new int[N];
        for (int i=0; i<N; ++i) {
            if (A[i] > N) {
                return 0;
            }
        }
        for (int i=0; i<N; ++i) {
            count[i] = 0;
        }
        for (int i=0; i<N; ++i) {
            count[A[i]-1] += 1;
        }
        for (int i=0; i<N; ++i) {
            if (count[i] != 1) {
                return 0;
            }
        }
        return 1;
    }
}
